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
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }

        public void CatListele()
        {
            var kategori = db.Tbl_Kategori.ToList();
            dataGridView1.DataSource = kategori;
        }
       

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            var kategori = db.Tbl_Kategori.ToList();
            dataGridView1.DataSource = kategori;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tbl_Kategori t = new Tbl_Kategori();
            t.AD = txtAD.Text;
            db.Tbl_Kategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi");
            CatListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtID.Text);
            var kategori = db.Tbl_Kategori.Find(x);
            db.Tbl_Kategori.Remove(kategori);
            db.SaveChanges() ;
            CatListele();
            MessageBox.Show("Kategori Silindi");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtID.Text);
            var kategori = db.Tbl_Kategori.Find(x);
            kategori.AD = txtAD.Text;
            db.SaveChanges();
            CatListele();
            MessageBox.Show("Güncelleme Yapıldı");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
