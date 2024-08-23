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
    public partial class frmPatientLogin : Form
    {
        public frmPatientLogin()
        {
            InitializeComponent();
        }

        sqlConnection bgl = new sqlConnection();

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPatientRegister fr = new frmPatientRegister();
            fr.ShowDialog();
            

        }

        private void frmPatientLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand com1 = new SqlCommand("Select * from Tbl_Patient where PatientTC=@p1 and PatientPassword=@p2",bgl.connection());
            com1.Parameters.AddWithValue("@p1",mskTC.Text);
            com1.Parameters.AddWithValue("@p2",txtPass.Text);
            SqlDataReader dr = com1.ExecuteReader();
            if(dr.Read())
            {
                this.Hide();
                frmPatientDetail fr = new frmPatientDetail();
                fr.tc=mskTC.Text;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Wrong Password or TC","Information",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
            bgl.connection().Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
