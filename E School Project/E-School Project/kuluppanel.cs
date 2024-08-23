using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_School_Project
{
    public partial class kuluppanel : Form
    {
        public kuluppanel()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection(@"Data Source=LICHSAN\KAANEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");

        public void liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_kulup", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void kuluppanel_Load(object sender, EventArgs e)
        {
            liste();

        }

        private void btnliste_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_kulup (KULUPAD) values (@p1) ",bgl);
            cmd.Parameters.AddWithValue("@p1", txtAD.Text);
            cmd.ExecuteNonQuery();
            bgl.Close();
            liste();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("update tbl_kulup set KULUPAD=@p1 where KULUPID=@p2", bgl);
            cmd.Parameters.AddWithValue("@p1", txtAD.Text);
            cmd.Parameters.AddWithValue("@p1", txtID.Text);
            cmd.ExecuteNonQuery();
            bgl.Close();
            liste();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("delete from tbl_kulup where KULUPID=@p1 ", bgl);
            cmd.Parameters.AddWithValue("@p1", txtID.Text);
            cmd.ExecuteNonQuery();
            bgl.Close();
            liste();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmogretmen frmogretmen = new frmogretmen();
            frmogretmen.Show();
            this.Hide();
        }
    }
}
