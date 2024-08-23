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
    public partial class frmSecretaryDetail : Form
    {
        public frmSecretaryDetail()
        {
            InitializeComponent();
        }
        sqlConnection bgl = new sqlConnection();
        public string TCnumara;
        
        private void frmSecretaryDetail_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCnumara;
            

            //Name
            SqlCommand cmd = new SqlCommand("Select SecretaryNameandSurname from Tbl_Secretary where SecretaryTC=@p1",bgl.connection());
            cmd.Parameters.AddWithValue("@p1",lblTC.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                lblNameSur.Text = dr[0].ToString();
            }
            bgl.connection().Close();

            //Branch
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branch", bgl.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Doctors
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoctorName + ' ' + DoctorSurname) as Doctors,DoctorBranch from Tbl_Doctor", bgl.connection());
            da2.Fill(dt2);
            dataGridView2.DataSource=dt2;

            //Branch to cmb
            SqlCommand cmd2 = new SqlCommand("Select BranchName from Tbl_Branch", bgl.connection());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while(dr2.Read())
            {
                cmbBranch.Items.Add(dr2[0].ToString());
            }
            bgl.connection().Close();

            //Doctor to cmb
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_App (AppDate,AppClock,AppBranch,AppDoctor) values (@p1,@p2,@p3,@p4)",bgl.connection());
            cmd.Parameters.AddWithValue("@p1",mskDate.Text);
            cmd.Parameters.AddWithValue("@p2",mskClock.Text);
            cmd.Parameters.AddWithValue("@p3",cmbBranch.Text);
            cmd.Parameters.AddWithValue("@p4",cmbDoctor.Text);
            cmd.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Appointment Created");
            

        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();
            SqlCommand cmd3 = new SqlCommand("Select DoctorName,DoctorSurname from Tbl_Doctor where DoctorBranch=@p1", bgl.connection());
            cmd3.Parameters.AddWithValue("@p1", cmbBranch.Text);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.connection().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.connection());
            cmd.Parameters.AddWithValue("@p1",richduyuru.Text);
            cmd.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Announcenment Created");
        }

        private void btnDoctorPanel_Click(object sender, EventArgs e)
        {
            frmSecDoctorPanel frm = new frmSecDoctorPanel();
            frm.Show();
        }

        private void btnBranchPanel_Click(object sender, EventArgs e)
        {
            frmSecBranchPanel frm = new frmSecBranchPanel();
            frm.Show();
            
        }

        private void btnAppList_Click(object sender, EventArgs e)
        {
            frmAppList frm = new frmAppList();
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void btnanno_Click(object sender, EventArgs e)
        {
            frmAnno frm = new frmAnno();
            frm.Show();
        }
    }
}
