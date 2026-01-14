using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsankaynaklariProje.Domain
{
    public class Maas
    {
        int id;
        public int Id
        {
            get; set;
        }
        int pid;
        public int PID
        {
            get; set;
        }
        double brut;
        public double Brut
        {
            get; set;
        }
        double bonus;
        public double Bonus
        {
            get; set;
        }
        double kesinti;
        public double Kesinti
        {
            get; set;
        }
        double net;
        public double Net
        {
            get; set;
        }
        DateTime odeme_tarih;
        public DateTime Odeme_tarih
        {
            get; set;
        }

        DateTime olusturma_tarih;
        public DateTime Olusturma_tarih
        {
            get; set;
        }

        public override string ToString()
        {
            return "Brut Maas:" + " " + this.Brut + " Net Maas:" + " " + this.Net + " PID: "+this.PID;
        }
    }
}
