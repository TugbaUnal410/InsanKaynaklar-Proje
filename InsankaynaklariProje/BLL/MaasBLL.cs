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
    public class MaasBLL
    {
        public static bool MaasKontrol(int pId,double net,double brut,double bonus, double kesinti)
        {
            {
                if (pId <= 0) return false;
                if (net <= 0) return false;
                if (brut <= 0) return false;
                if (bonus <= 0) return false;
                if (kesinti <= 0) return false;
                return true;
            }
        }
        public void Maas_Ekle(int gPid, double gBrut, double gBonus, double gKesinti, double gNet, DateTime gOdeme, DateTime gOlusturma)
        {

            Maas m = new Maas();

            m.PID = gPid;
            m.Brut = gBrut;
            m.Bonus = gBonus;
            m.Kesinti = gKesinti;
            m.Net = gNet;
            m.Odeme_tarih = gOdeme;
            m.Olusturma_tarih = gOlusturma;

            (new MaasDAL()).m_ekle(m);


        }
        public void Maas_Sil(int gId)
        {

            if (gId == null || gId <= 0) return;
            (new MaasDAL()).m_sil(gId);

        }
        public void Maas_Guncelle(int gId, int gPid, double gBrut, double gBonus, double gKesinti, double gNet, DateTime gOdeme, DateTime gOlusturma)
        {

            Maas m = new Maas();
            m.Id = gId;
            m.PID = gPid;
            m.Net = gNet;
            m.Brut = gBrut;
            m.Bonus = gBonus;
            m.Kesinti = gKesinti;
            m.Net = gNet;
            m.Odeme_tarih = gOdeme;
            m.Olusturma_tarih = gOlusturma;

            (new MaasDAL()).m_guncelle(m);


        }

        public ArrayList Maas_List()
        {
            return (new MaasDAL()).maasList();
        }
    }
}
