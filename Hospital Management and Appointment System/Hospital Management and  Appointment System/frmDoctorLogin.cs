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
    public partial class frmDoctorLogin : Form
    {
        public frmDoctorLogin()
        {
            InitializeComponent();
        }
        sqlConnection bgl = new sqlConnection();
        private void frmDoctorLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Doctor where DoctorTC=@p1 and DoctorPassword=@p2", bgl.connection());
            cmd.Parameters.AddWithValue("@p1", mskTC.Text);
            cmd.Parameters.AddWithValue("@p2", txtPass.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                frmDoctorDetail frm = new frmDoctorDetail();
                frm.tc1=mskTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password or Username");
            }
            bgl.connection().Close();
        }
    }
}
