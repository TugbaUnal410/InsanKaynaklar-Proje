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
    public class IzinDAL
    {
       

            public void izin_ekle(Izin gIzin)
            {
                MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
                baglan.Open();
                string query = "INSERT INTO Izin(pID,ToplamGunsayisi,IstenilenGunSayisi,KalanGunsayisi,Durum,Neden) " +
                 "VALUES ('" +
                 gIzin.PID + "','" +
                 gIzin.Toplam_gun + "','" +
                 gIzin.Istenilen_gun + "','" +
                 gIzin.Kalan_gun + "','" +
                 gIzin.Durum + "','" +
                 gIzin.Neden + "')";

                new MySqlCommand(query, baglan).ExecuteNonQuery();
                baglan.Close();

            }

            public void DurumGuncelle(int ID, string yenidurum)
            {
                MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
                baglan.Open();
                (new MySqlCommand("Update Izin set Durum='" + yenidurum + "'where ID=" + ID, baglan)).ExecuteNonQuery();
                baglan.Close();
            }


            public ArrayList bekleyenızinler(int gId)
            {
                ArrayList izinler = new ArrayList();
                MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
                baglan.Open();
                MySqlCommand query = new MySqlCommand("select IstenilenGunSayisi,Durum,Neden from Izin where pID=" + gId, baglan);
                MySqlDataReader okunan = query.ExecuteReader();
                while (okunan.Read())
                {
                    Izin i = new Izin();
                    i.Istenilen_gun = Convert.ToInt32(okunan["IstenilenGunSayisi"]);
                    i.Durum = okunan["Durum"].ToString();
                    i.Neden = okunan["Neden"].ToString();
                    izinler.Add(i);
                }


                baglan.Close();
                return izinler;
            }
            public ArrayList onayBekleyenIzinler()
            {
                ArrayList izinler = new ArrayList();
                MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
                baglan.Open();
                MySqlCommand sorgu = new MySqlCommand("select * from Izin where Durum='Beklemede'", baglan);
                MySqlDataReader okunanlar = sorgu.ExecuteReader();
                while (okunanlar.Read())
                {
                    Izin i = new Izin();
                    i.ID = Convert.ToInt32(okunanlar["ID"]);
                    i.PID = Convert.ToInt32(okunanlar["pID"]);
                    i.Toplam_gun = Convert.ToInt32(okunanlar["ToplamGunSayisi"]);
                    i.Istenilen_gun = Convert.ToInt32(okunanlar["IstenilenGunSayisi"]);
                    i.Kalan_gun = Convert.ToInt32(okunanlar["KalanGunSayisi"]);
                    i.Durum = okunanlar["Durum"].ToString();
                    i.Neden = okunanlar["Neden"].ToString();
                    izinler.Add(i);
                }
               okunanlar.Close();
                baglan.Close();
                return izinler;
            }

            public int kalanGunHesabi()
            {
                int toplam = 0;
                MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
                baglan.Open();
                MySqlCommand query = new MySqlCommand("select IstenilenGunSayisi from Izin where pID=" + Oturum.Pid + " and Durum in ('Onaylandi','Onaylandı')", baglan);
                MySqlDataReader okunan = query.ExecuteReader();
                while (okunan.Read())
                {
                    toplam += Convert.ToInt32(okunan["IstenilenGunSayisi"]);
                }
                baglan.Close();
                return toplam;
            }
     }
}
