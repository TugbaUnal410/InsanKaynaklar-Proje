using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace InsankaynaklariProje.Domain
{
    public class Izin
    {
        int id;
        public int ID
        {
            get; set;
        }
        int pid;
        public int PID
        {
            get; set;
        }
        int toplam_gun;
        public int Toplam_gun { get ; set ; }
        int istenilen_gun;
        public int Istenilen_gun { get ; set ; }


        int kalan_gun;
        public int Kalan_gun
        {
            get; set;
        }
        string durum;
        public string Durum
        {
            get; set;
        }
        string neden;
        public string Neden
        {
            get; set;
        }



        public override string ToString()
        {
            return "Personel ID: " + PID + " - Gün: " + Istenilen_gun + " - Sebep: " + Neden;
        }
    }
}
