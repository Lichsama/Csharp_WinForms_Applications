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
    public partial class frmSecretaryLogin : Form
    {
        public frmSecretaryLogin()
        {
            InitializeComponent();
        }

        sqlConnection bgl = new sqlConnection();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select SecretaryTC,SecretaryPassword from Tbl_Secretary where SecretaryTC=@p1 and SecretaryPassword=@p2", bgl.connection());
            cmd.Parameters.AddWithValue("@p1", mskTC.Text);
            cmd.Parameters.AddWithValue("@p2", txtPass.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader();
            if(rd.Read())
            {
                this.Hide();
                
                frmSecretaryDetail frm = new frmSecretaryDetail();
                frm.TCnumara=mskTC.Text;
                frm.Show();
                
            }

        }

        private void frmSecretaryLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
