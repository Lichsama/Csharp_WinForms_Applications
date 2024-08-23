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
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection(@"Data Source=LICHSAN\KAANEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("Select OGRID from tbl_ogr where OGRID=@p1",bgl);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                frmogrnotlar frm = new frmogrnotlar();
                frm.numara = textBox1.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ID not found");
            }
            bgl.Close();


            
            
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            bgl.Open();
            SqlCommand cmd = new SqlCommand("Select OGRTID from tbl_ogrt where OGRTID=@p1", bgl);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                frmogretmen frm = new frmogretmen();
                
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ID not found");
            }
            bgl.Close();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
