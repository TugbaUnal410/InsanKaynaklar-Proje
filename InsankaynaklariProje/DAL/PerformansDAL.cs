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
    public class PerformansDAL
    {
        public ArrayList performansList()
        {
            ArrayList maaslar = new ArrayList();
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlCommand query = new MySqlCommand("select*from Performans", baglan);
            MySqlDataReader okunanlar = query.ExecuteReader();
            while (okunanlar.Read())
            {
                Performans pd = new Performans();
                pd.ID = Convert.ToInt32(okunanlar[0]);
                pd.Pid = Convert.ToInt32(okunanlar[1]);
                pd.Donem = okunanlar[2].ToString();
                pd.Puan = Convert.ToInt32(okunanlar[3]);
                pd.Olusturma_tarih = Convert.ToDateTime(okunanlar[4]);
                maaslar.Add(pd);

            }
            return maaslar;
            baglan.Close();
        }



        public void performans_ekle(Performans p)
        {
            string tarih = p.Olusturma_tarih.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("insert into Performans(pID,DegerlendirmeDonemi,PerformansPuani,OlusturmaTarihi) values('" +
                  Convert.ToInt32(p.Pid) + "','" + p.Donem + "','" + Convert.ToInt32(p.Puan) + "','" +
                tarih+ "')", baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();
        }
        public void performans_sil(int gId)
        {
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            (new MySqlCommand("delete from Performans where ID=" + gId, baglan)).ExecuteNonQuery();
            baglan.Close();
        }
        public void performans_guncelle(Performans p)
        {
            string tarih = p.Olusturma_tarih.ToString("yyyy-MM-dd HH:mm:ss");
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            (new MySqlCommand("update Performans set pID='" + p.Pid + "', DegerlendirmeDonemi='" + p.Donem + "', PerformansPuani='" + p.Puan + "', OlusturmaTarihi='" + tarih + "' where ID=" + p.ID, baglan)).ExecuteNonQuery();
            baglan.Close();
        }
    }
}
