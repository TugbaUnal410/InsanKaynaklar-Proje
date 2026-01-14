using InsankaynaklariProje.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsankaynaklariProje.BLL
{
    public class YetkiBLL
    {
        public static bool YetkisiVarMi (string islem)
        {
            switch (Oturum.Gorev)
            {
                case "Yonetici":
                    return true;
                case "IK":
                    return islem != "Rapor" && islem != "IzinOnay";
                case "Personel":
                    return islem == "İzinTalep";
                default:
                    return false;
            }

        }
    }
}
