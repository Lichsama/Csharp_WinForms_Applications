using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EntityProjectApplication
{
    public partial class frmUrun : Form
    {
        public frmUrun()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void frmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.Tbl_Kategori select new { x.ID, x.AD }).ToList();
            combokategori.ValueMember = "ID";
            combokategori.DisplayMember = "AD";
            combokategori.DataSource = kategoriler;
        }

        public void Listele()
        {
            dataGridView1.DataSource = (from x in db.Tbl_Urun
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.URUNMARKA,
                                            x.URUNSTOK,
                                            x.URUNFIYAT,
                                            x.Tbl_Kategori.AD,
                                            x.URUNDURUM
                                        }).ToList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tbl_Urun t = new Tbl_Urun();
            t.URUNAD = txtAD.Text;
            t.URUNSTOK = int.Parse(txtSTOK.Text);
            t.URUNMARKA = txtMARKA.Text;
            t.URUNFIYAT = decimal.Parse(txtFiyat.Text);
            t.KATEGORI = int.Parse(combokategori.SelectedValue.ToString());
            t.URUNDURUM = true;
            db.Tbl_Urun.Add(t);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Ürün Eklendi");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtID.Text);
            var urun = db.Tbl_Urun.Find(x);
            db.Tbl_Urun.Remove(urun);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Ürün Silindi");

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtID.Text);
            var t = db.Tbl_Urun.Find(x);
            t.URUNAD = txtAD.Text;
            t.URUNMARKA = txtMARKA.Text;
            t.URUNSTOK = int.Parse(txtSTOK.Text);
            t.URUNFIYAT = decimal.Parse(txtFiyat.Text);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Güncellendi");

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[x].Cells[0].Value.ToString();
            txtAD.Text = dataGridView1.Rows[x].Cells[1].Value.ToString();
            txtMARKA.Text = dataGridView1.Rows[x].Cells[2].Value.ToString();
            txtSTOK.Text = dataGridView1.Rows[x].Cells[3].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[x].Cells[4].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[x].Cells[5].Value.ToString();
            combokategori.SelectedValue = dataGridView1.Rows[x].Cells[6].Value;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var kategoriler = (from x in db.Tbl_Kategori select new { x.ID, x.AD }).ToList();
            combokategori.ValueMember = "ID";
            combokategori.DisplayMember = "AD";
            combokategori.DataSource = kategoriler;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }
    }
}
