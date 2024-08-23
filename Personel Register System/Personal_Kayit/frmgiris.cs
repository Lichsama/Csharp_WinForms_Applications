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
using System.Security.Cryptography;

namespace Personal_Kayit
{
    public partial class frmgiris : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LICHSAN\\KAANEXPRESS;Initial Catalog=PersonalVeriTabani;Integrated Security=True;");
        public frmgiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From tbl_yonetici where kullaniciAd=@p1 and sifre=@p2 " , baglanti);
            komut.Parameters.AddWithValue("@p1", txtKullanici.Text);
            komut.Parameters.AddWithValue("@p2", txtPass.Text);
            SqlDataReader dr = komut.ExecuteReader();   
            if(dr.Read())
            {
                frmAna frm = new frmAna();
                frm.Show();
                this.Hide();
                
                
                
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre");

            }
            baglanti.Close();
        }

        private void frmgiris_Load(object sender, EventArgs e)
        {

        }
    }
}
