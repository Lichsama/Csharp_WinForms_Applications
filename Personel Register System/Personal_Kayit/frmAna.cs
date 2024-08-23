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

namespace Personal_Kayit
{
    
    public partial class frmAna : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LICHSAN\\KAANEXPRESS;Initial Catalog=PersonalVeriTabani;Integrated Security=True;");
        


        void temizle()
        {
            txtID.Text = "";
            txtAD.Text = "";
            txtSoyAD.Text = "";
            txtMeslek.Text = "";
            cmbSehir.Text = "";
            mtbMaas.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtAD.Focus();
        }

        void listele()
        {
            this.tbL_PersonalTableAdapter.Fill(this.personalVeriTabaniDataSet.TbL_Personal);
        }

        public frmAna()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalVeriTabaniDataSet.TbL_Personal' table. You can move, or remove it, as needed.
            
            


        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.tbL_PersonalTableAdapter.Fill(this.personalVeriTabaniDataSet.TbL_Personal);

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TbL_Personal (PerAD,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAD.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyAD.Text);
            komut.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", mtbMaas.Text);
            komut.Parameters.AddWithValue("@p5", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();
            listele();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "True";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "False";
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyAD.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mtbMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            if(label8.Text == "True")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From TbL_Personal Where PerID=@p1 ", baglanti);
            komutsil.Parameters.AddWithValue("@p1",txtID.Text);
            komutsil.ExecuteNonQuery();
            listele();
            baglanti.Close();
            MessageBox.Show("Komut Silindi");
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncel = new SqlCommand("Update TbL_Personal Set PerAD=@p1,PerSoyad=@p2,PerSehir=@p3,PerMaas=@p4,PerDurum=@p5,PerMeslek=@p6 Where PerID=@p7", baglanti);
            komutguncel.Parameters.AddWithValue("@p1",txtAD.Text);
            komutguncel.Parameters.AddWithValue("@p2",txtSoyAD.Text);
            komutguncel.Parameters.AddWithValue("@p3",cmbSehir.Text);
            komutguncel.Parameters.AddWithValue("@p4",mtbMaas.Text);
            komutguncel.Parameters.AddWithValue("@p5",label8.Text);
            komutguncel.Parameters.AddWithValue("@p6",txtMeslek.Text);
            komutguncel.Parameters.AddWithValue("@p7",txtID.Text);
            komutguncel.ExecuteNonQuery();
            listele();
            baglanti.Close();
        }

        private void btnist_Click(object sender, EventArgs e)
        {
            Frmist fr = new Frmist();
            fr.Show();
        }

        private void btngrafik_Click(object sender, EventArgs e)
        {
            frmgrafik frg = new frmgrafik();
            frg.Show();
        }
    }
}
