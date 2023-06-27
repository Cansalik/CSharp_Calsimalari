using System;
using System.Collections.Generic;
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
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand Com = new SqlCommand("select * from Tbl_Bilgi",Baglanti.bgl);
            if (Com.Connection.State!= ConnectionState.Open)
            {
                Com.Connection.Open();
            }
            SqlDataReader dr = Com.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();
                ent.Gorev = dr["GOREV"].ToString();
                ent.Sehir = dr["SEHIR"].ToString();
                ent.Maas = short.Parse(dr["MAAS"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int PersonelEkle(EntityPersonel p)
        {

            SqlCommand Com = new SqlCommand("insert into Tbl_Bilgi (AD,SOYAD,GOREV,SEHIR,MAAS) values (@V1,@V2,@V3,@V4,@V5)",Baglanti.bgl);

            if (Com.Connection.State != ConnectionState.Open)
            {
                Com.Connection.Open();
            }

            Com.Parameters.AddWithValue("@V1", p.Ad);
            Com.Parameters.AddWithValue("@V2", p.Soyad);
            Com.Parameters.AddWithValue("@V3", p.Gorev);
            Com.Parameters.AddWithValue("@V4", p.Sehir);
            Com.Parameters.AddWithValue("@V5", p.Maas);
            return Com.ExecuteNonQuery();
        }

        public static bool PerSonelSil(int p)
        {
            SqlCommand Com = new SqlCommand("delete from Tbl_Bilgi where ID = @V1",Baglanti.bgl);
            if (Com.Connection.State != ConnectionState.Open)
            {
                Com.Connection.Open();
            }
            Com.Parameters.AddWithValue("@V1", p);
            return Com.ExecuteNonQuery() > 0;
        }

        public static bool  PersonelGuncelle(EntityPersonel ent)
        {
            SqlCommand Com = new SqlCommand("update Tbl_Bilgi set AD=@V1, SOYAD=@V2, MAAS=@V3, SEHIR=@V4, GOREV=@V5 where ID=@V6",Baglanti.bgl);
            if (Com.Connection.State != ConnectionState.Open)
            {
                Com.Connection.Open();
            }

            Com.Parameters.AddWithValue("@V1",ent.Ad);
            Com.Parameters.AddWithValue("@V2",ent.Soyad);
            Com.Parameters.AddWithValue("@V3",ent.Maas);
            Com.Parameters.AddWithValue("@V4",ent.Sehir);
            Com.Parameters.AddWithValue("@V5",ent.Gorev);
            Com.Parameters.AddWithValue("@V6",ent.Id);
            return Com.ExecuteNonQuery() > 0;
        }

    }
}
