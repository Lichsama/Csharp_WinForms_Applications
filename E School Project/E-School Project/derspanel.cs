using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_School_Project
{
    public partial class derspanel : Form
    {
        public derspanel()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmogretmen frmogretmen = new frmogretmen();
            frmogretmen.Show();
            this.Hide();
        }
        DataSet1TableAdapters.tbl_dersTableAdapter ds = new DataSet1TableAdapters.tbl_dersTableAdapter();
        private void derspanel_Load(object sender, EventArgs e)
        {
            
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txtAD.Text);
            
            
        }

        private void btnliste_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(txtID.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ds.dersgüncelle(txtAD.Text, byte.Parse(txtID.Text));
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

       
    }
}
