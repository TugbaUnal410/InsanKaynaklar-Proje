using InsankaynaklariProje.DAL;
using InsankaynaklariProje.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace InsankaynaklariProje.BLL
{
    public class OturumBLL
    {
        public bool Giris(string gKullaniciAdi, string gSifre)
        {
            OturumDAL k = new OturumDAL();
            return k.GirisKontrol(gKullaniciAdi, gSifre);

        }
    }
}
