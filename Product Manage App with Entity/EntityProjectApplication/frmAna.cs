using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjectApplication
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmistatistik t = new frmistatistik();
            t.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKategori t = new frmKategori();
            t.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUrun t = new frmUrun();
            t.Show();
        }

        private void frmAna_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAna_Load(object sender, EventArgs e)
        {
            
        }
    }
}
