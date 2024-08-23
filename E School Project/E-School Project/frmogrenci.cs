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

namespace E_School_Project
{
    public partial class frmogrenci : Form
    {
        public frmogrenci()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.tbl_ogrTableAdapter ds = new DataSet1TableAdapters.tbl_ogrTableAdapter();

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmogretmen frmogretmen = new frmogretmen();
            frmogretmen.Show();
            this.Hide();
        }

        private void btnliste_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.GetData();
        }

        private void frmogrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.GetData();
            SqlConnection bgl = new SqlConnection(@"Data Source=LICHSAN\KAANEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");
            bgl.Open();
            SqlCommand cmd = new SqlCommand("Select * from tbl_kulup", bgl);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            comboBox1.DisplayMember = "KULUPAD";
            comboBox1.ValueMember = "KULUPID";
            comboBox1.DataSource = dt;
        }
        string c = "";
        private void button2_Click(object sender, EventArgs e)
        {
            
            if(radioButton1.Checked==true)
            {
                c = "FEMALE";
            }
            else
            {
                c = "MALE";
            }
            ds.InsertQuery(txtAD.Text, textBox1.Text, Convert.ToInt32(comboBox1.SelectedValue.ToString()), c);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtID.Text = comboBox1.SelectedValue.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ds.DeleteQuery(int.Parse(txtID.Text));
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            if (c == "FEMALE")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource= ds.ögrencigetir(txtAD.Text);
        }
    }
}
