using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_and__Appointment_System
{
    public partial class frmLogins : Form
    {
        public frmLogins()
        {
            InitializeComponent();
        }
      
        private void btnPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPatientLogin fr3 = new frmPatientLogin();
            fr3.Show();
            
            
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoctorLogin fr1 = new frmDoctorLogin();
            fr1.Show();
            
        }

        private void btnSecretary_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSecretaryLogin fr2 = new frmSecretaryLogin();
            fr2.Show();
            
        }
        private void frmLogins_Load(object sender, EventArgs e)
        {

        }


    }
}
