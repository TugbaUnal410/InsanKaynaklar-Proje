using InsankaynaklariProje.DAL;
using InsankaynaklariProje.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InsankaynaklariProje.BLL
{
    public class DepartmanBLL
    {
        public static bool DepartmanKontrol(string ad,int kat,string iletisim)
        {
            if (string.IsNullOrWhiteSpace(ad)) return false;
            if (kat<=0)return false;
            if (string.IsNullOrWhiteSpace(iletisim)) return false;
            
            return true;

        }
        public void Departman_Ekle(string gAd, int gKat, string gIletisim, DateTime gTarih)
        {
            Departman d = new Departman();
            d.Adi = gAd;
            d.Kati = gKat;
            d.Iletisim = gIletisim;
            d.Tarih = gTarih;

          (new DepartmanDAL()).d_ekle(d);
        }


        public void Departman_Sil(int gId)
        {
            if (gId == null || gId <= 0) return;

            Departman dal = new Departman();
            dal.ID = gId;
            (new DepartmanDAL()).d_sil(gId);
        }
        public void Departman_Guncelle(int gID, string gAd, int gKat, string gIletisim, DateTime gTarih)
        {
            Departman d = new Departman();
            d.ID = gID;
            d.Adi = gAd;
            d.Kati = gKat;
            d.Iletisim = gIletisim;
            d.Tarih = gTarih;

         

            (new DepartmanDAL()).d_guncelle(d);


        }

        public ArrayList Departman_Listele()
        {
            return (new DepartmanDAL()).departmanList();
        }
        public ArrayList Departman()
        {
            return (new DepartmanDAL()).departman();
        }
    }
}
