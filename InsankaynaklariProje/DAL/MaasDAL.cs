using InsankaynaklariProje.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsankaynaklariProje.DAL
{
    public class MaasDAL
    {
        public ArrayList maasList()
        {
            ArrayList maaslar = new ArrayList();
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select*from Maas", baglan);
            MySqlDataReader okunanlar = cmd.ExecuteReader();
            while (okunanlar.Read())
            {
                Maas m = new Maas();
                m.Id = Convert.ToInt32(okunanlar[0]);
                m.PID = Convert.ToInt32(okunanlar[1]);
                m.Brut = Convert.ToDouble(okunanlar[2]);
                m.Bonus = Convert.ToDouble(okunanlar[3]);
                m.Kesinti = Convert.ToDouble(okunanlar[4]);
                m.Net = Convert.ToDouble(okunanlar[5]);
                m.Odeme_tarih = Convert.ToDateTime(okunanlar[6]);
                m.Olusturma_tarih = Convert.ToDateTime(okunanlar [7]);
                maaslar.Add(m);
            }
            return maaslar;
            baglan.Close();

        }


        public void m_ekle(Maas m)
        {
            string odemetarih = m.Odeme_tarih.ToString("yyyy-MM-dd HH:mm:ss");
            string olusturmatarih = m.Olusturma_tarih.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            (new MySqlCommand("insert into Maas(pID,BrutMaas,Bonus,Kesintiler,NetMaas,OdenmeTarihi,OlusturmaTarihi)values('" +
                                                     Convert.ToInt32(m.PID) + "','" + Convert.ToDouble(m.Brut) + "','" +
                                                   Convert.ToDouble(m.Bonus) + "','" + Convert.ToDouble(m.Kesinti) + "','" + Convert.ToDouble(m.Net) + "','" +
                                                 odemetarih + "','" + olusturmatarih + "')", baglan)).ExecuteNonQuery();
            baglan.Close();
        }
        public void m_sil(int gId)
        {
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            (new MySqlCommand("delete from Maas where ID=" + gId, baglan)).ExecuteNonQuery();
            baglan.Close();
        }
        public void m_guncelle(Maas m)
        {
            string odemetarih = m.Odeme_tarih.ToString("yyyy-MM-dd HH:mm:ss");
            string olusturmatarih = m.Olusturma_tarih.ToString("yyyy-MM-dd HH:mm:ss");
           
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            (new MySqlCommand("UPDATE Maas SET " +
                 "PID=" + m.PID + "," +
                 "BrutMaas=" + m.Brut + "," +
                 "Bonus=" + m.Bonus + "," +
                 "Kesintiler=" + m.Kesinti + "," +
                 "NetMaas=" + m.Net + "," +
                 "OdenmeTarihi='" + odemetarih + "'," +
                 "OlusturmaTarihi='" + olusturmatarih + "' " +
                 "WHERE ID=" + m.Id, baglan)).ExecuteNonQuery();
            baglan.Close();

        }
    }
}
