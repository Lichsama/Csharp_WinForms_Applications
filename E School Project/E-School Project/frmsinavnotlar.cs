using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E_School_Project
{
    public partial class frmsinavnotlar : Form
    {
        public frmsinavnotlar()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmogretmen frmogretmen = new frmogretmen();
            frmogretmen.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        DataSet1TableAdapters.tbl_notTableAdapter ds = new DataSet1TableAdapters.tbl_notTableAdapter();
        private void frmsinavnotlar_Load(object sender, EventArgs e)
        {
            
            SqlConnection bgl = new SqlConnection(@"Data Source=LICHSAN\KAANEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");
            bgl.Open();
            SqlCommand cmd = new SqlCommand("Select * from tbl_ders", bgl);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            comboBox1.DisplayMember = "DERSAD";
            comboBox1.ValueMember = "DERSID";
            comboBox1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.notlistesi(int.Parse(txtID.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            notid=int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEX1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtE2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPRO.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtAVG.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtPASS.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value;



        }
        int notid;
        int s1, s2, proje;
        double avg;
        string durum;
        private void btnCal_Click(object sender, EventArgs e)
        {
            

            s1=Convert.ToInt32(txtEX1.Text);
            s2=Convert.ToInt32(txtE2.Text);
            proje=Convert.ToInt32(txtPRO.Text);
            avg=(s1+s2+proje)/3;
            txtAVG.Text=avg.ToString();
            if(avg>=50)
            {
                txtPASS.Text = "True";
            }
            else
            {
                txtPASS.Text = "False";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.UpdateQuery(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(txtID.Text), byte.Parse(txtEX1.Text), byte.Parse(txtE2.Text),
                byte.Parse(txtPRO.Text), decimal.Parse(txtAVG.Text), bool.Parse(txtPASS.Text),notid);
        }
    }
}
