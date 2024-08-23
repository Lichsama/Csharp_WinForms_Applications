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
    public partial class frmDoctorDetail : Form
    {
        public frmDoctorDetail()
        {
            InitializeComponent();
        }
        sqlConnection bgl = new sqlConnection();
        public string tc1;

        private void lblTC_Click(object sender, EventArgs e)
        {

        }

        private void frmDoctorDetail_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc1;
            SqlCommand cmd = new SqlCommand("Select DoctorName,DoctorSurname from Tbl_Doctor where DoctorTC=@p1",bgl.connection());
            cmd.Parameters.AddWithValue("@p1",lblTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblNameSur.Text = dr[0] + " " + dr[1];
            }
            bgl.connection().Close();


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_App where AppDoctor='" + lblNameSur.Text + "'", bgl.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmDoctorUpdateInfo frm = new frmDoctorUpdateInfo();
            frm.tcno2=lblTC.Text;
            frm.Show();
        }

        private void btnAnno_Click(object sender, EventArgs e)
        {
            frmAnno frm = new frmAnno();
            frm.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchProblem.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
