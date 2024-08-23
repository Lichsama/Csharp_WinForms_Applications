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

namespace Hospital_Management_and__Appointment_System
{
    public partial class frmPatientUpdateInfo : Form
    {
        public frmPatientUpdateInfo()
        {
            InitializeComponent();
        }

        public string tcno;

        sqlConnection bgl = new sqlConnection();
        private void frmPatientUpdateInfo_Load(object sender, EventArgs e)
        {
            mskTC.Text = tcno;
            SqlCommand com1 = new SqlCommand("Select * from Tbl_Patient where PatientTC=@p1",bgl.connection());
            com1.Parameters.AddWithValue("@p1",mskTC.Text);
            SqlDataReader dr = com1.ExecuteReader();
            while(dr.Read()) 
            {
                txtName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString();
                mskPhone.Text = dr[4].ToString();
                txtPass.Text = dr[5].ToString();
                cmbSex.Text = dr[6].ToString();

            }
            bgl.connection().Close(); 


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand com1 = new SqlCommand("Update Tbl_Patient set PatientName=@p1,PatientSurname=@p2,PatientTel=@p3,PatienPassword=@p4 where PatientTC=@p5", bgl.connection());
            com1.Parameters.AddWithValue("@p1", txtName.Text);
            com1.Parameters.AddWithValue("@p2", txtSurname.Text);
            com1.Parameters.AddWithValue("@p3", mskPhone.Text);
            com1.Parameters.AddWithValue("@p4", txtPass.Text);
            com1.Parameters.AddWithValue("@p5", mskTC.Text);
            com1.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Updated Suscessfuly");
            
        }
    }
}
