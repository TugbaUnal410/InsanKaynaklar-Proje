using InsankaynaklariProje.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
namespace InsankaynaklariProje.DAL
{
    public class RaporDAL
    {
        public DataTable personelGetir()
        {
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();

            MySqlDataAdapter okunanlar = new MySqlDataAdapter("select*from Personel", baglan);
            DataTable dt = new DataTable();
            okunanlar.Fill(dt);
            baglan.Close();
            return dt;
        }
        public DataTable departmanGetir()
        {
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlDataAdapter okunan = new MySqlDataAdapter("select*from Departman", baglan);
            DataTable dt = new DataTable();
            okunan.Fill(dt);
            baglan.Close();
            return dt;


        }

        public object izinGerir()
        {
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlDataAdapter okunan = new MySqlDataAdapter("select*from Izin", baglan);
            DataTable dt = new DataTable();
            okunan.Fill(dt);
            baglan.Close();
            return dt;

        }
        public DataTable tumMaaslar()
        {
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlDataAdapter okunan = new MySqlDataAdapter("select * from Maas", baglan);
            DataTable dt = new DataTable();
            okunan.Fill(dt);
            baglan.Close();
            return dt;

        }

        public object maasGetir(DateTime baslangic,DateTime bitis)
        {
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlDataAdapter okunan = new MySqlDataAdapter("select p.Ad,p.Soyad,m.BrutMaas,m.OdenmeTarihi,d.Ad as DepartmanAdi "+
                                                                "from Maas m "+
                                                                " JOIN Personel p ON p.ID = m.PID " +
                                                                    "JOIN Departman d ON d.ID = p.dID " +
                                                                    "WHERE m.OdenmeTarihi BETWEEN '" +
                                                                    baslangic.ToString("yyyy-MM-dd") +
                                                                    "' AND '" +
                                                                    bitis.ToString("yyyy-MM-dd")+"'", baglan);
                                                            
            DataTable dt = new DataTable();
            okunan.Fill(dt);
            baglan.Close();
            return dt;
        }

        public object performansGetir()
        {
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlDataAdapter okunan = new MySqlDataAdapter("select*from Performans", baglan);
            DataTable dt = new DataTable();
            okunan.Fill(dt);
            baglan.Close();
            return dt;
        }
        public DataTable pozisyonGetir()
        {
            DataTable dt = new DataTable();
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlDataAdapter okunan = new MySqlDataAdapter("select Pozisyon from Personel", baglan);
            okunan.Fill(dt);
            baglan.Close();
            return dt;
        }
        public DataTable pozisyondakşPersoneller(string pozisyon)
        {
            DataTable dt = new DataTable();
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlDataAdapter okunan = new MySqlDataAdapter("select * from Personel where Pozisyon= '" + pozisyon + "'", baglan);
            okunan.Fill(dt);
            baglan.Close();
            return dt;
        }
        public DataTable Personelizinleri()
        {
            DataTable d = new DataTable();
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlDataAdapter okunan = new MySqlDataAdapter("select Ad,Soyad ,SUM(IstenilenGunSayisi) AS ToplamIzin  " + " from Personel,Izin where Personel.Id= Izin.PID " +
                                                         " Group by Ad,Soyad" + " Order by ToplamIzin DESC", baglan);

            // SUM= personelin izin günlerini toplamk için kullanıldı
            //AS:toplanılan izin günlerini ToplamIzin adında bir sütün oluşturum buraya yazdı
            //GROUP BY=aynı personele ait birden fazla izin kaydını tek bir satırda yazmak için kullnıldı
            //ORDER BY DESC=DESC büyükten küçüğe izinleri sıraladı ORDER BY de sırlanan sonuçları yazmak için kullanıldı
            //DESC: azalan şeklinde demek
            okunan.Fill(d);
            baglan.Close();
            return d;

        }
        public DataTable performanslarıGetir(DateTime baslangic,DateTime bitis)
        {
            DataTable d = new DataTable();
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlDataAdapter okunan = new MySqlDataAdapter("SELECT p.Ad, p.Soyad, SUM(PerformansPuani) AS ToplamPerformans " +
                                                                                    "FROM Performans pr " +
                                                                                    "JOIN Personel p ON pr.PID = p.ID " +
                                                                                    "JOIN Departman d ON d.ID = p.DID " +
                                                                                    "WHERE pr.OlusturmaTarihi BETWEEN '" +
                                                                                    baslangic.ToString("yyyy-MM-dd") +
                                                                                    "' AND '" +
                                                                                    bitis.ToString("yyyy-MM-dd") +
                                                                                    "' " +
                                                                                    "GROUP BY p.Ad, p.Soyad", baglan);

            okunan.Fill(d);
            baglan.Close();
            return d;
        }
        public DataTable personelGetir(int departmanId)
        {
            DataTable dt = new DataTable();
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlDataAdapter okunan = new MySqlDataAdapter("select * from Personel where dID= " + departmanId, baglan);
            okunan.Fill(dt);
            baglan.Close();
            return dt;

        }
        public DataTable departmanPerformanslari(DateTime baslangic,DateTime bitis)
        {
            DataTable dt = new DataTable();
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlDataAdapter okunan = new MySqlDataAdapter("SELECT d.Ad AS DepartmanAdi, " +
                                                                         "SUM(per.PerformansPuani) AS ToplamPerformans " +
                                                                         "FROM Performans per " +
                                                                         "INNER JOIN Personel p ON per.PID = p.ID " +
                                                                         "INNER JOIN Departman d ON p.dID = d.ID " +
                                                                         "WHERE per.OlusturmaTarihi BETWEEN '" +
                                                                             baslangic.ToString("yyyy-MM-dd") +
                                                                             "' AND '" +
                                                                             bitis.ToString("yyyy-MM-dd") + "' " +
                                                                         "GROUP BY d.Ad",baglan);
            okunan.Fill(dt);
            baglan.Close();
            return dt;
        }
       public DataTable Maasyuku(int ay,int yil)
       {
            DataTable dt = new DataTable();
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlDataAdapter okunan = new MySqlDataAdapter("SELECT d.Ad AS DepartmanAdi, " +
                                                                "SUM(m.BrutMaas) AS ToplamMaasYuku " +
                                                                "FROM Departman d " +
                                                                "INNER JOIN Personel p ON p.dID = d.ID " +
                                                                "INNER JOIN Maas m ON m.PID = p.ID " +
                                                                "WHERE MONTH(m.OdenmeTarihi) = " + ay + " " +
                                                                "AND YEAR(m.OdenmeTarihi) = " + yil + " " +
                                                                "GROUP BY d.Ad " +
                                                                "ORDER BY ToplamMaasYuku DESC ", baglan);
                                                                
                                               //inner join: Kesişim demektir. İlgili tabloların kesiştiği satırları getirir.
                                               // on:Eşleşme şartıdır.İki tabloyu hangi şart doğruldusunda bağlayacağım.
                                               
            okunan.Fill(dt);
            baglan.Close();
            return dt;
        }
        public DataTable enYuksekBesPerformans()
        {
            DataTable dt = new DataTable();
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlDataAdapter okunan = new MySqlDataAdapter("SELECT p.Ad, p.Soyad, SUM(f.PerformansPuani) AS ToplamPerformans " +
                                                                                     "FROM Personel p, Performans f " +
                                                                                     "WHERE p.Id = f.PID " +
                                                                                     "GROUP BY p.Id, p.Ad, p.Soyad " +
                                                                                     "ORDER BY ToplamPerformans DESC " +
                                                                                     "LIMIT 5;", baglan);

            okunan.Fill(dt);
            baglan.Close();
            return dt;
        }
        public DataTable enuksekBesMaas(int ay,int yil)
        {
            DataTable dt = new DataTable();
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlDataAdapter okunan = new MySqlDataAdapter("SELECT Ad, Soyad, SUM(NetMaas) AS ToplamNetMaas " +
                                                        "FROM Personel p, Maas m " +
                                                        "WHERE p.Id = m.PID " +
                                                        "AND MONTH(m.OdenmeTarihi) = " + ay + " " +
                                                        "AND YEAR(m.OdenmeTarihi) = " + yil + " " +
                                                        "GROUP BY p.Id, Ad, Soyad " +
                                                        "ORDER BY ToplamNetMaas DESC " +
                                                        "LIMIT 5", baglan);
                                                //Limit 5: 5 ile sınırlandırdım ekranda en yüksek 5 kişinin maaşı gözükecek
            okunan.Fill(dt);
            baglan.Close();
            return dt;
        }
        public DataTable enYuksekBesIzin()
        {
            DataTable dt = new DataTable();
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlDataAdapter okunan = new MySqlDataAdapter("SELECT p.Id, p.Ad, p.Soyad, " +
                                                    "SUM(i.IstenilenGunSayisi) AS ToplamKullanilanIzin " +
                                                    "FROM Personel p " +
                                                    "JOIN Izin i ON i.PID = p.Id " +
                                                    "WHERE i.Durum LIKE '%Onay%' " +
                                                    "GROUP BY p.Id, p.Ad, p.Soyad " +
                                                    "ORDER BY ToplamKullanilanIzin DESC " +
                                                    "LIMIT 5",
                                                    baglan);

            okunan.Fill(dt);
            baglan.Close();
            return dt;
        }
    }
}
