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
    public class PerformansBLL
    {
        public static bool PerformansKontrol(int pid,int puan,string donem)
        {
            if(pid == 0) return false;
            if(puan == 0) return false;
            if(string.IsNullOrWhiteSpace(donem)) return false;
            return true;
        }
        public void Performans_Ekle(int gPid, int gPuan, DateTime gTarih, string gDonem)
        {
            Performans pd = new Performans();
            pd.Pid = gPid;
            pd.Puan = gPuan;
            pd.Olusturma_tarih = gTarih;
            pd.Donem = gDonem;

            (new PerformansDAL()).performans_ekle(pd);
        }
        public void Performans_Sil(int gId)
        {
            PerformansDAL dal = new PerformansDAL();
            if (gId <= 0) return;

            dal.performans_sil(gId);

        }
        public void Performans_Guncelle(int gId, int gPid, int gPuan, DateTime gTarih, string  gDonem)
        {
            Performans pd = new Performans();
            pd.ID = gId;
            pd.Puan = gPuan;
            pd.Pid = gPid;
            pd.Olusturma_tarih = gTarih;
            pd.Donem = gDonem;

            (new PerformansDAL()).performans_guncelle(pd);

        }
        public ArrayList Performans_List()
        {
            return (new PerformansDAL()).performansList();
        }

    }
}
