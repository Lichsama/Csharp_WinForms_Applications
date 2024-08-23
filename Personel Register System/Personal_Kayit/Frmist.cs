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
    public partial class Frmist : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LICHSAN\\KAANEXPRESS;Initial Catalog=PersonalVeriTabani;Integrated Security=True;");


        public Frmist()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frmist_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1=new SqlCommand("Select count(*) from TbL_Personal",baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                toplamPer.Text = dr1[0].ToString();
            }
            baglanti.Close();
            
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) from TbL_Personal where PerDurum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                evliper.Text = dr2[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) from TbL_Personal where PerDurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                bekarper.Text = dr3[0].ToString();
            }
            baglanti.Close();

            baglanti.Open ();
            SqlCommand komut4 = new SqlCommand("Select count(distinct(PerSehir)) From TbL_Personal", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                sehirsay.Text = dr4[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) from TbL_Personal", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                toplammaas.Text = dr5[0].ToString();
            }
            baglanti.Close();

            baglanti.Open ();
            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaas) from TbL_Personal", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                ortmaas.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
