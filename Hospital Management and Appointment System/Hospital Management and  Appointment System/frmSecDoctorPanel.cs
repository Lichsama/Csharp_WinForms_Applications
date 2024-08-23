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

namespace Hospital_Management_and__Appointment_System
{
    public partial class frmSecDoctorPanel : Form
    {
        public frmSecDoctorPanel()
        {
            InitializeComponent();
        }
        sqlConnection bgl = new sqlConnection();
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Doctor set DoctorName=@p1,DoctorSurname=@p2,DoctorBranch=@p3,DoctorPassword=@p5 where DoctorTC=@p4", bgl.connection());
            cmd.Parameters.AddWithValue("@p1", txtName.Text);
            cmd.Parameters.AddWithValue("@p2", txtSurName.Text);
            cmd.Parameters.AddWithValue("@p3", cmbBranch.Text);
            cmd.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@p5", txtPass.Text);
            cmd.ExecuteNonQuery();
            bgl.connection().Close();
            
            MessageBox.Show("Register Updated");
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Doctor (DoctorName,DoctorSurname,DoctorBranch,DoctorTC,DoctorPassword) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.connection());
            cmd.Parameters.AddWithValue("@p1", txtName.Text);
            cmd.Parameters.AddWithValue("@p2", txtSurName.Text);
            cmd.Parameters.AddWithValue("@p3", cmbBranch.Text);
            cmd.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@p5", txtPass.Text);
            cmd.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Doctor User Registered");
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSurName.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBranch.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtPass.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from Tbl_Doctor where DoctorTC=@p1",bgl.connection());
            cmd.Parameters.AddWithValue("@p1",maskedTextBox1.Text);
            cmd.ExecuteNonQuery();
            bgl.connection().Close( );
            MessageBox.Show("Register Deleted");
        }

        private void frmSecDoctorPanel_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
