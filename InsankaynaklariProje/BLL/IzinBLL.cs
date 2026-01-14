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
     class IzinBLL
     {
        public ArrayList OnayBekleyenIzinler()
        {
            return (new IzinDAL()).onayBekleyenIzinler();
        }

        public static bool IzinKontrol(string neden,int istenilenGun)
        {
            if(string.IsNullOrWhiteSpace(neden)) return false;
            if(istenilenGun<=0) return false;
            return true;
        }
        public void Izın_talep( int gIstenenGun, string gAciklama)
        {
            Izin dal = new Izin();
            dal.PID=Oturum.Pid;
            
            dal.Toplam_gun = 14;
            dal.Istenilen_gun = gIstenenGun;
            dal.Kalan_gun = 14 - gIstenenGun;
            dal.Durum = "Beklemede";
            dal.Neden = gAciklama;

            if (dal.Kalan_gun < 0)
                return;

            (new IzinDAL()).izin_ekle(dal);


        }
        public void izinOnayla(int ID)
        {
            IzinDAL dAL = new IzinDAL();
            dAL.DurumGuncelle(ID, "Onaylandi");

        }
        public void izinReddet(int ID)
        {
            IzinDAL dAL = new IzinDAL();
            dAL.DurumGuncelle(ID, "Reddedildi");
        }
        public ArrayList BekleyenIzinler(int gId)
        {
            IzinDAL i = new IzinDAL();
            return i.bekleyenızinler(gId);
        }
        public void IzınGuncelle(int ID, string durum)
        {
            IzinDAL dal = new IzinDAL();
            dal.DurumGuncelle(ID, durum);
        }
        public int KalanGunHrsabi()
        {
            IzinDAL i = new IzinDAL();
            return i.kalanGunHesabi();

        }


    }
}
