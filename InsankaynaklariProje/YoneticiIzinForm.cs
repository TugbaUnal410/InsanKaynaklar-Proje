using InsankaynaklariProje.BLL;
using InsankaynaklariProje.DAL;
using InsankaynaklariProje.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsankaynaklariProje
{
    public partial class YoneticiIzinForm : Form
    {
        public YoneticiIzinForm()
        {
            InitializeComponent();
        }
        int secilenIzinId;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void izinOku()
        {
            PersonelIzinTalepList.Items.Clear();
            ArrayList okunanlar = (new IzinBLL()).OnayBekleyenIzinler();
            PersonelIzinTalepList.Items.Clear();
            foreach (Izin okunan in okunanlar)
            {
                
                PersonelIzinTalepList.Items.Add(okunan);
            }
        }
        private void YoneticiIzinForm_Load(object sender, EventArgs e)
        {
            izinOku();
        }

        private void onaylaBtn_Click(object sender, EventArgs e)
        {
            int secilenId = (((Izin)PersonelIzinTalepList.SelectedItem).ID);
          
            if (secilenId == 0)
            {
                MessageBox.Show("Lufen talep edilen bir izin secin");
            }
            (new IzinBLL()).izinOnayla(secilenId);
            MessageBox.Show("Izin talebi  onaylandi");
            izinOku();
        }

        private void reddetBtn_Click(object sender, EventArgs e)
        {
            int secilenId = (((Izin)PersonelIzinTalepList.SelectedItem).ID);
            
            if (secilenId == 0)
            {
                MessageBox.Show("Lufen talep edilen bir izin secin");
            }
            (new IzinBLL()).izinReddet(secilenId);
            MessageBox.Show("Izin talebi  reddedildi");
            izinOku();
        }

        private void PersonelızınTalepList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PersonelIzinTalepList.SelectedItem == null) return;
            Izin i = (Izin)PersonelIzinTalepList.SelectedItem;
            pidTxt.Text = i.PID.ToString();
            istenilenGunTxt.Text = i.Istenilen_gun.ToString();
            aciklamaTxt.Text = i.Neden.ToString();
        }

        private void anaMenuBtn_Click(object sender, EventArgs e)
        {
            AnaMenuForm ana = new AnaMenuForm();
            ana.Show();
            this.Close();
        }

        private void cıkısBtn_Click(object sender, EventArgs e)
        {
            OturumForm o = new OturumForm();
            o.Show();
            this.Close();
        }
    }
}
