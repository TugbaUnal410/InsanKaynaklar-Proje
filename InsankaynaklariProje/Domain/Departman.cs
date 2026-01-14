using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsankaynaklariProje.Domain
{
    public class Departman
    {
        int id;
        public int ID { get; set; }
        string ad;
        public string Adi { get; set; }
        int kat;
        public int Kati { get; set; }
        string iletisim;
        public string Iletisim { get; set; }
        DateTime tarih;
        public DateTime Tarih { get; set; }
        public override string ToString()
        {
            return this.Adi + "(" + this.ID + ")";
        }
    }
}
