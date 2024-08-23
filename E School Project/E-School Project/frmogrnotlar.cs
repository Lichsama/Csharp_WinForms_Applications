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
using System.Data.SqlClient;

namespace E_School_Project
{
    public partial class frmogrnotlar : Form
    {
        public frmogrnotlar()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection(@"Data Source=LICHSAN\KAANEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");
        public string numara;
        private void frmogrnotlar_Load(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("select OGRAD,OGRSOYAD where OGRID=@P1", bgl);
            cmd1.Parameters.AddWithValue("@P1", numara);
           // this.Text = da1.ToString();

            SqlCommand cmd = new SqlCommand("select DERSAD,SINAV1,SINAV2,PROJE,ORTALAMA,DURUM from tbl_not\r\nINNER JOIN tbl_ders on tbl_not.DERSID=tbl_ders.DERSID where OGRID=@P1", bgl);
            cmd.Parameters.AddWithValue("@P1", numara);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void frmogrnotlar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
