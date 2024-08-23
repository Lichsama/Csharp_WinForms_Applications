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
    public partial class frmAnno : Form
    {
        public frmAnno()
        {
            InitializeComponent();
        }

        sqlConnection bgl = new sqlConnection();
        private void frmAnno_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Duyurular",bgl.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
