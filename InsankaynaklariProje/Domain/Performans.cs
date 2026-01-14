using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsankaynaklariProje.Domain
{
    public class Performans
    {
        int id;
        public int ID
        {
            get; set;
        }
        int pid;
        public int Pid
        {
            get; set;
        }
        string donem;
        public string Donem
        {
            get; set;
        }
        int puan;
        public int Puan
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
            return "Puan: " + this.Puan.ToString() + "ID:" + this.Pid.ToString();
        }
    }
}
