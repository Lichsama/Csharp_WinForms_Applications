using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EntityProjectApplication
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        public void button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.Tbl_admin where x.KULLANICIADI == textBox1.Text && x.ŞİFRE == textBox5.Text select x;
            if (sorgu.Any())
            { 
                frmAna t = new frmAna();
                t.Show();
                this.Hide();
                t.Closed += (s, args) => this.Close();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }

            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
