using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NKatmanlıMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> Perlist = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource=   Perlist;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = t2.Text;
            ent.Soyad = t3.Text;
            ent.Sehir = t4.Text;
            ent.Gorev = t5.Text;
            ent.Maas = int.Parse(t6.Text);
            LogicPersonel.LLPersonelEkle(ent);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.ID=Convert.ToInt32(t1.Text);
            LogicPersonel.LLPersonelSil(ent.ID);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.ID = Convert.ToInt32(t1.Text);
            ent.Ad = t2.Text;
            ent.Soyad= t3.Text;
            ent.Sehir= t4.Text;
            ent.Gorev= t5.Text;
            ent.Maas= int.Parse(t6.Text);
            LogicPersonel.LLPersonelGüncelle(ent);

        }
    }
}
