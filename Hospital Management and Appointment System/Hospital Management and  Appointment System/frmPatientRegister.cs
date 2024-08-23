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
    public partial class frmPatientRegister : Form
    {
        public frmPatientRegister()
        {
            InitializeComponent();
        }

        sqlConnection bgl = new sqlConnection();

        private void frmPatientRegister_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlCommand com1 = new SqlCommand("insert into Tbl_Patient (PatientName,PatientSurname,PatientTC,PatientTel,PatientPassword,PatientSex) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.connection());
            com1.Parameters.AddWithValue("@p1",txtName.Text);
            com1.Parameters.AddWithValue("@p2",txtSurname.Text);
            com1.Parameters.AddWithValue("@p3",mskTC.Text);
            com1.Parameters.AddWithValue("@p4",mskPhone.Text);
            com1.Parameters.AddWithValue("@p5",txtPass.Text);
            com1.Parameters.AddWithValue("@p6",cmbSex.Text);
            com1.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Registered Successfuly","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
    }
}
