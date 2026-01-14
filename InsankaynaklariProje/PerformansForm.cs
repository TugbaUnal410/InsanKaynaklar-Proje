using InsankaynaklariProje.BLL;
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
    public partial class PerformansForm : Form
    {
        public PerformansForm()
        {
            InitializeComponent();
        }
        public void performans_oku()
        {
            ArrayList okunanlar = (new PerformansBLL()).Performans_List();
            PerformansList.Items.Clear();
            foreach (Performans okunan in okunanlar)
            {
                PerformansList.Items.Add(okunan);

            }
        }

        private void PerformansForm_Load(object sender, EventArgs e)
        {
            performans_oku();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
           
            int pid, puan;

          if (!int.TryParse(pidTxt.Text, out pid))
           {
                MessageBox.Show("Personel Id bilgisi sayısal değer almalıdır.");
                return;
           }
            if (!int.TryParse(puanTxt.Text, out puan))
            {
                MessageBox.Show("Personel puan bilgisi sayısal değer almalıdır.");
                return;
            }
            bool kontrol= PerformansBLL.PerformansKontrol(Convert.ToInt32(pidTxt.Text),Convert.ToInt32(puanTxt.Text),donemTxt.Text);
            if (!kontrol)
            {
                MessageBox.Show("Performans bilgileri hatalı ve yanlış girildi!\n\n" +
                    "• Personel ID 0'dan büyük olmalı \n" +
                    "• Performans puanı 0'dan büyük olmalı \n" +
                    "• Degerlendirme donemi boş olmamlı \n");
                return;
            }
                (new PerformansBLL()).Performans_Ekle(Convert.ToInt32(pidTxt.Text), Convert.ToInt32(puanTxt.Text), date.Value, donemTxt.Text);
            performans_oku();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {

            if (PerformansList.SelectedItem == null)
            {
                MessageBox.Show("Silmek istediginiz performans degerini seciniz");
                return;
            }
            (new PerformansBLL()).Performans_Sil(((Performans)PerformansList.SelectedItem).ID);
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {

           
            if (PerformansList.SelectedItem == null)
            {
                MessageBox.Show("Guncellemek istediginiz performans degerini seciniz");
                return;
            }

            int pid, puan;

            if (!int.TryParse(pidTxt.Text, out pid))
            {
                MessageBox.Show("Personel Id bilgisi sayısal değer almalıdır.");
                return;
            }
            if (!int.TryParse(puanTxt.Text, out puan))
            {
                MessageBox.Show("Personel puan bilgisi sayısal değer almalıdır.");
                return;
            }
            bool kontrol = PerformansBLL.PerformansKontrol(Convert.ToInt32(pidTxt.Text), Convert.ToInt32(puanTxt.Text), donemTxt.Text);
            if (!kontrol)
            {
                MessageBox.Show("Performans bilgileri hatalı ve yanlış girildi!\n\n" +
                    "• Personel ID 0'dan büyük olmalı \n" +
                    "• Performans puanı 0'dan büyük olmalı \n" +
                    "• Degerlendirme donemi boş olmamlı \n");
                return;
            }
            (new PerformansBLL()).Performans_Guncelle(((Performans)PerformansList.SelectedItem).ID, Convert.ToInt32(pidTxt.Text), Convert.ToInt32(puanTxt.Text), date.Value, donemTxt.Text);
            performans_oku();
        }

        private void PerformansList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PerformansList.SelectedItem == null) return;
            Performans p = (Performans)PerformansList.SelectedItem;
            pidTxt.Text = p.Pid.ToString();
            puanTxt.Text = p.Puan.ToString();
            date.Text = p.Olusturma_tarih.ToString();
            donemTxt.Text = p.Donem;
        }

        private void anaMenuBtn_Click(object sender, EventArgs e)
        {
            AnaMenuForm a = new AnaMenuForm();
            a.Show();
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
