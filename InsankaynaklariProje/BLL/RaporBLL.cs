using InsankaynaklariProje.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InsankaynaklariProje.BLL
{
    public class RaporBLL
    {
        public DataTable PersonelGetir()
        {
            return (new RaporDAL()).personelGetir();
        }
        public DataTable DepartmanGetir()
        {
            return (new RaporDAL()).departmanGetir();
        }

        public object IzinGetir()
        {
            return (new RaporDAL()).izinGerir();
        }

        public object MaasGetir(DateTime baslangic,DateTime bitis)
        {
            return (new RaporDAL()).maasGetir(baslangic,bitis);
        }
        public DataTable TumMaaslar()
        {
            return (new RaporDAL()).tumMaaslar();
        }

        public DataTable PersonelGetir(int departmanId)
        {
            return (new RaporDAL()).personelGetir(departmanId);

        }
        public DataTable PersonelIzinleri()
        {
            return (new RaporDAL()).Personelizinleri();
        }
        public DataTable PerformansGetir(DateTime baslangic,DateTime bitis)
        {
            return (new RaporDAL()).performanslarıGetir(baslangic,bitis);
        }
        public DataTable DepartmanPerformanslari(DateTime baslangic,DateTime bitis)
        {
            return (new RaporDAL()).departmanPerformanslari(baslangic,bitis);
        }
       public DataTable MaasYuku(int ay, int yil)
        {
            return (new RaporDAL()).Maasyuku(ay,yil);
        }
        public DataTable EnYuksekBesPerformans()
        {
            return (new RaporDAL()).enYuksekBesPerformans();
        }
        public DataTable EnYuksekBesMaas(int ay,int yil)
        {
            return (new RaporDAL()).enuksekBesMaas(ay,yil);
        }
        public DataTable EnYuksekBesIzin()
        {
            return (new RaporDAL()).enYuksekBesIzin();
        }
    }
}
