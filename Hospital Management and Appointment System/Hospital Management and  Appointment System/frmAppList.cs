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
    public partial class frmAppList : Form
    {
        public frmAppList()
        {
            InitializeComponent();
        }

        sqlConnection bgl = new sqlConnection();

        public int s1;
        public string AppDate;
        public string AppClock;
        public string AppBranch;
        public string AppDoctor;

        private void frmAppList_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_App", bgl.connection());
            da.Fill(dt);
            asd.DataSource = dt;
        }

        public int secilen;
        public void asd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           secilen = asd.SelectedCells[0].RowIndex;
        }

        
    }
}
