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
    public class PersonelBLL
    {
        public static bool PersonelKontrol(string ad,string soyad,string tel,int did,string pozisyon)
        {
            if(string.IsNullOrWhiteSpace(ad)) return false;
            if(string.IsNullOrWhiteSpace(soyad)) return false;
            if(string.IsNullOrWhiteSpace(tel)) return false;
            if(did==0)return false;
            if(string.IsNullOrWhiteSpace(pozisyon)) return false;
            return true;
        }
        public void Personel_Ekle(string gAd, string gSoyad, int gDid, string gPozisyon, DateTime gBaslangic, string gTel, string gEposta, DateTime gOlusturma)
        {
            Personel p = new Personel();
            p.Ad = gAd;
            p.Soyad = gSoyad;
            p.Did = gDid;
            p.Pozisyon = gPozisyon;
            p.Baslangic_tarih = gBaslangic;
            p.Tel = gTel;
            p.Eposta = gEposta;
            p.OLusturulan_Tarih = gOlusturma;
         
            (new PersonelDAL()).p_ekle(p);
        }
        public void Personel_Sil(int gId)
        {
            if (gId <= 0) return;
            (new PersonelDAL()).p_sil(gId);

        }
        public void Personel_Guncelle(int gId, string gAd, string gSoyad, int gDid, string gPozisyon, DateTime gBaslangictarih, string gTel, string gEposta, DateTime gOlusturulantarih)
        {

            Personel p = new Personel();
            p.Id = gId;
            p.Ad = gAd;
            p.Soyad = gSoyad;
            p.Did = gDid;
            p.Pozisyon = gPozisyon;
            p.Baslangic_tarih = gBaslangictarih;

            p.Tel = gTel;
            p.Eposta = gEposta;
            p.OLusturulan_Tarih = gOlusturulantarih;

            (new PersonelDAL()).p_guncelle(p);
        }

        public ArrayList Personel_List()
        {
            return (new PersonelDAL()).personelList();
        }
    }
}
