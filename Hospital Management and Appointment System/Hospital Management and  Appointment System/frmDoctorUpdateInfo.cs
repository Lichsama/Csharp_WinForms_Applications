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
    public partial class frmDoctorUpdateInfo : Form
    {
        public frmDoctorUpdateInfo()
        {
            InitializeComponent();
        }

        sqlConnection bgl = new sqlConnection();
        public string tcno2;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Doctor set DoctorName=@p1,DoctorSurname=@p2,DoctorBranch=@p3,DoctorPassword=@p4 where DoctorTC=@p5", bgl.connection());
            cmd.Parameters.AddWithValue("@p1",txtName.Text);
            cmd.Parameters.AddWithValue("@p2",txtSurname.Text);
            cmd.Parameters.AddWithValue("@p3",comboBox1.Text);
            cmd.Parameters.AddWithValue("@p4",txtPass.Text);
            cmd.Parameters.AddWithValue("@p5",txtPass.Text);
            cmd.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Updated");


        }

        private void frmDoctorUpdateInfo_Load(object sender, EventArgs e)
        {
            mskTC.Text = tcno2;

            SqlCommand cmd = new SqlCommand("Select * from Tbl_Doctor where DoctorTC=@p1", bgl.connection());
            cmd.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString();
                comboBox1.Text = dr[3].ToString();
                txtPass.Text = dr[5].ToString();
            }
            bgl.connection().ToString();
        }
    }
}
