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
    public class DepartmanDAL
    {
        public void d_ekle(Departman gDepartman)
        {
            string tarih = gDepartman.Tarih.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            (new MySqlCommand("insert into Departman (Ad,Kati,Iletisim,OlusturmaTarihi) values('" +

                                                                 gDepartman.Adi + "','" + Convert.ToInt32(gDepartman.Kati) + "','" + gDepartman.Iletisim + "','" +
                                                                tarih + "')", baglan)).ExecuteNonQuery();
            baglan.Close();

        }
        public void d_sil(int gDID)
        {
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            (new MySqlCommand("delete from Departman where Id=" + gDID, baglan)).ExecuteNonQuery();
            baglan.Close();

        }
        public void d_guncelle(Departman d)
        {
            string tarih = d.Tarih.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            (new MySqlCommand("UPDATE Departman SET " +
                        "Ad='" + d.Adi + "', " +
                        "Kati=" + d.Kati + ", " +
                        "Iletisim='" + d.Iletisim + "', " +
                        "OlusturmaTarihi='" + tarih + "' " +
                        "WHERE Id=" + d.ID, baglan)).ExecuteNonQuery();
            baglan.Close();

        }





        public ArrayList departmanList()
        {
            ArrayList departmanlar = new ArrayList();
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlCommand komut = new MySqlCommand("select* from Departman", baglan);
            MySqlDataReader okunan = komut.ExecuteReader();
            while (okunan.Read())
            {
                Departman d = new Departman();
                d.ID = Convert.ToInt32(okunan[0]);
                d.Adi = okunan[1].ToString();
                d.Kati = Convert.ToInt32(okunan[2]);
                d.Iletisim = okunan[3].ToString();
                d.Tarih = Convert.ToDateTime(okunan[4]);
                departmanlar.Add(d);
            }
            baglan.Close();
            return departmanlar;

        }
        public ArrayList departman()
        {
            ArrayList departman = new ArrayList();
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlCommand komut = new MySqlCommand("select Id,Ad from Departman", baglan);
            MySqlDataReader okunan = komut.ExecuteReader();
            while (okunan.Read())
            {
                Departman d = new Departman();
                d.ID = Convert.ToInt32(okunan[0]);
                d.Adi = okunan[1].ToString();
                departman.Add(d);
            }
            baglan.Close();
            return departman;
        }
    }
}
