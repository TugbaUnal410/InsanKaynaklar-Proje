using InsankaynaklariProje.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsankaynaklariProje.DAL
{
    public class OturumDAL
    {
        public bool GirisKontrol(string gKullaniciAdi, string gSifre)
        {
            string gorev = "";
            MySqlConnection baglan = new MySqlConnection("Server=172.21.54.253;Database=26_132430072;User ID=26_132430072;Password=İnif123.;");
            baglan.Open();
            MySqlCommand cmd = new MySqlCommand("select * from Kullanici where KullaniciAdi='" + gKullaniciAdi +
                  "' and Sifre='" + gSifre + "'", baglan);
              

            MySqlDataReader okunan = cmd.ExecuteReader();
            if (okunan.Read())
            {
                gorev = okunan["Gorev"].ToString();
                Oturum.Gorev = gorev;
                Oturum.Sifre = okunan["Sifre"].ToString();
                Oturum.Pid = Convert.ToInt32(okunan["ID"]);

                okunan.Close();
                baglan.Close();
                return true;

            }


            okunan.Close();
            baglan.Close();
            return false;

        }
    }
}
