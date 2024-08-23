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
    public partial class frmistatistik : Form
    {
        public frmistatistik()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void frmistatistik_Load(object sender, EventArgs e)
        {
            label2.Text=db.Tbl_Kategori.Count().ToString();
            label2.Text=db.Tbl_Urun.Count().ToString();
            label5.Text=db.Tbl_Musteri.Count(x=>x.DURUM==true).ToString();
            label7.Text=db.Tbl_Musteri.Count(x=>x.DURUM==false).ToString();
            label15.Text = db.Tbl_Urun.Count(x => x.KATEGORI == 1).ToString();
            label13.Text = db.Tbl_Urun.Sum(x => x.URUNSTOK).ToString();
            label11.Text=(from x in db.Tbl_Urun orderby x.URUNFIYAT descending select x.URUNAD).FirstOrDefault().ToString();
            label9.Text=(from x in db.Tbl_Urun orderby x.URUNFIYAT ascending select x.URUNAD).FirstOrDefault().ToString();
            label23.Text =(from x in db.Tbl_Musteri select x.SEHIR).Distinct().Count().ToString();
            label21.Text = db.Tbl_Urun.Sum(x => x.URUNFIYAT).ToString() + "TL" ;
            label17.Text=db.Tbl_Urun.Count(x=>x.URUNAD=="Buzdolabı").ToString();
            label19.Text = db.MARKAGETIR().FirstOrDefault();
            



        }
            
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
