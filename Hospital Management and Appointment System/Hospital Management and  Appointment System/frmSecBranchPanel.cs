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
using System.Xml.Linq;

namespace Hospital_Management_and__Appointment_System
{
    public partial class frmSecBranchPanel : Form
    {
        public frmSecBranchPanel()
        {
            InitializeComponent();
        }

        sqlConnection bgl = new sqlConnection();

        private void frmSecBranchPanel_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branch", bgl.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Branch (BrancName) values (@p1)",bgl.connection());
            cmd.Parameters.AddWithValue("@p1", txtBName.Text);
            cmd.ExecuteNonQuery();
            bgl.connection().Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtBID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete Tbl_Branch where BranchID=@p1)", bgl.connection());
            cmd.Parameters.AddWithValue("@p1", txtBID.Text);
            cmd.ExecuteNonQuery();
            bgl.connection().Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Branch set BranchName=@p2 where BranchID=@p1", bgl.connection());
            cmd.Parameters.AddWithValue("@p1", txtBID.Text);
            cmd.Parameters.AddWithValue("@p2", txtBName.Text);
            cmd.ExecuteNonQuery();
            bgl.connection().Close();

            MessageBox.Show("Register Updated");
        }
    }
}
