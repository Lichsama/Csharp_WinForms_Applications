using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static List<EntityPersonel> Personellistesi()
        {
            List<EntityPersonel> degeler = new List<EntityPersonel>();
            SqlCommand komut1 = new SqlCommand("Select * from tbl_bilgi", Baglanti.bgl);
            if(komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.ID = int.Parse(dr["ID"].ToString());
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();
                ent.Gorev = dr["GOREV"].ToString();
                ent.Maas = int.Parse(dr["MAAS"].ToString());
                ent.Sehir = dr["SEHIR"].ToString() ;
                degeler.Add(ent);
            }
            dr.Close();
            komut1.Connection.Close();
            return degeler;
        }

        public static int PersonelEkle(EntityPersonel p )
        {
            
            SqlCommand komut2 = new SqlCommand("insert into tbl_bilgi (AD,SOYAD,SEHIR,GOREV,MAAS) values (@p1,@p2,@p3,@p4,@p5)",Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1",p.Ad);
            komut2.Parameters.AddWithValue("@p2",p.Soyad);
            komut2.Parameters.AddWithValue("@p3",p.Sehir);
            komut2.Parameters.AddWithValue("@p4",p.Gorev);
            komut2.Parameters.AddWithValue("@p5",p.Maas);
            return komut2.ExecuteNonQuery();


        }

        public static bool PersonelSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete from tbl_bilgi where ID=@P1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", p);
            return komut3.ExecuteNonQuery()>0;
        }

        public static bool PersonelGüncelle(EntityPersonel entity)
        {
            SqlCommand komut4 = new SqlCommand("Update tbl_bilgi set AD=@p1,SOYAD=@p2,SEHIR=@p3,GOREV=@p4,MAAS=@p5) WHERE ID=@p6", Baglanti.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", entity.Ad);
            komut4.Parameters.AddWithValue("@p2", entity.Soyad);
            komut4.Parameters.AddWithValue("@p3", entity.Sehir);
            komut4.Parameters.AddWithValue("@p4", entity.Gorev);
            komut4.Parameters.AddWithValue("@p5", entity.Maas);
            komut4.Parameters.AddWithValue("@p6", entity.ID);
            return komut4.ExecuteNonQuery() > 0;
        }

    }
}
