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
    public partial class frmPatientDetail : Form
    {
        public frmPatientDetail()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            frmPatientUpdateInfo frm = new frmPatientUpdateInfo();
            frm.tcno = lblTC.Text;
            frm.Show();
        }
        public string tc;
        sqlConnection bgl = new sqlConnection();
        private void frmPatientDetail_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;
            SqlCommand com1 = new SqlCommand("Select PatientName,PatientSurname from Tbl_Patient where PatientTC=@p1",bgl.connection());
            com1.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = com1.ExecuteReader();
            while(dr.Read())
            {
                lblNameSur.Text = dr[0] +" "+ dr[1];
            }

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_App where PatientTC=" + tc, bgl.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları Çekme
            SqlCommand com2 = new SqlCommand("Select BranchName from Tbl_Branch", bgl.connection());
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranch.Items.Add(dr2[0]);
            }
            bgl.connection().Close();

        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand com3 = new SqlCommand("Select DoctorName,DoctorSurname from Tbl_Doctor where DoctorBranch=@p1", bgl.connection());
            com3.Parameters.AddWithValue("@p1",cmbBranch.Text);
            SqlDataReader dr3 = com3.ExecuteReader();
            while(dr3.Read())
            {
                cmbDoctor.Items.Add(dr3[0]+" " + dr3[1]);
            }
            bgl.connection().Close();
        }

       

        private void btnAppoint_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_App set AppAvailable=1,PatientTC=@p1,PatientProblem=@p2 where AppID=@p3", bgl.connection());
            cmd.Parameters.AddWithValue("@p1", lblTC.Text);
            cmd.Parameters.AddWithValue("@p2", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@p2", txtID.Text);
            cmd.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Appointment Created");
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_App where AppBranch='" + cmbBranch.Text + "'" + " and AppDoctor='" + cmbDoctor.Text + "' and AppAvailable=0", bgl.connection());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();     
        }
    }
}
