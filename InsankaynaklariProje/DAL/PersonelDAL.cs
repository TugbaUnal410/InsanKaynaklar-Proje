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
    public class PersonelDAL
    {
        public ArrayList personelList()
        {
            ArrayList personeller = new ArrayList();
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlCommand komut = new MySqlCommand("select*from Personel", baglan);
            MySqlDataReader okunanlar = komut.ExecuteReader();
            while (okunanlar.Read())
            {
                Personel p = new Personel();
                p.Id = Convert.ToInt32(okunanlar[0]);
                p.Ad = okunanlar[1].ToString();
                p.Soyad = okunanlar[2].ToString();
                p.Did = Convert.ToInt32(okunanlar[3]);
                p.Pozisyon = okunanlar[4].ToString();
                p.Baslangic_tarih = Convert.ToDateTime(okunanlar[5]);

                p.Tel = okunanlar[6].ToString();
                p.Eposta = okunanlar[7].ToString();
                p.OLusturulan_Tarih = Convert.ToDateTime(okunanlar[8]);
                personeller.Add(p);
            }
            baglan.Close();
            return personeller;

        }

        public void p_ekle(Personel p)
        {
            string baslangictarih = p.Baslangic_tarih.ToString("yyyy-MM-dd HH:mm:ss");
            string olusturmatarih = p.OLusturulan_Tarih.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlCommand oku = new MySqlCommand("INSERT INTO Personel " +
                                                "(Ad, Soyad, dID, Pozisyon, IsBaslangicTarih, Tel, Eposta, OlusturmaTarihi) VALUES (" +
                                                "'" + p.Ad + "'," +
                                                "'" + p.Soyad + "'," +
                                                p.Did + "," +
                                                "'" + p.Pozisyon + "'," +
                                                "'" + baslangictarih + "'," +
                                                "'" + p.Tel + "'," +
                                                "'" + p.Eposta + "'," +
                                                "'" + olusturmatarih + "')",baglan);
            oku.ExecuteNonQuery();

            baglan.Close();
        }
        public void p_sil(int gId)
        {
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            (new MySqlCommand("delete from Personel where ID=" + gId, baglan)).ExecuteNonQuery();
            baglan.Close();

        }
        public void p_guncelle(Personel p)
        {
            string baslangictarih = p.Baslangic_tarih.ToString("yyyy-MM-dd HH:mm:ss");
            string olusturmatarih = p.OLusturulan_Tarih.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            (new MySqlCommand("UPDATE Personel SET " +
                                                        "Ad='" + p.Ad + "', " +
                                                        "Soyad='" + p.Soyad + "', " +
                                                        "dID=" + Convert.ToInt32(p.Did) + ", " +
                                                        "Pozisyon='" + p.Pozisyon + "', " +
                                                        "IsBaslangicTarih='" + baslangictarih + "', " +
                                                        "Tel='" + p.Tel + "', " +
                                                        "Eposta='" + p.Eposta + "', " +
                                                        "OlusturmaTarihi='" + olusturmatarih + "' " +
                                                        "WHERE ID=" + p.Id, baglan)).ExecuteNonQuery();

            baglan.Close();
        }
    }
}
