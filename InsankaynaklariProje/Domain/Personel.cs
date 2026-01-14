using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsankaynaklariProje.Domain
{
    public class Personel
    {
        int id;
        public int Id
        {
            get; set;
        }
        string ad;
        public string Ad
        {
            get; set;
        }
        string soyad;
        public string Soyad
        {
            get; set;
        }
        int did;
        public int Did
        {
            get; set;
        }

        string pozisyon;
        public string Pozisyon
        {
            get; set;
        }

        DateTime baslangic_tarih;
        public DateTime Baslangic_tarih
        {
            get; set;
        }

        string tel;
        public string Tel
        {
            get; set;
        }
        string eposta;
        public string Eposta
        {
            get; set;
        }

         DateTime olusturulan_tarih;
        public DateTime OLusturulan_Tarih
        {
            get; set;

        }
        public override string ToString()
        {
            return  "Personel Adı:" +  this.Ad +" - "+ " Personel Soyadı" + this.Soyad+ " - "+" Personel ID:" + " (" +this.Id + ")";
        }

    }
}
