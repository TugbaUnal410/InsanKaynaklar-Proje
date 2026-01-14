using InsankaynaklariProje.BLL;
using InsankaynaklariProje.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsankaynaklariProje
{
    public partial class DepartmanForm : Form
    {
        public DepartmanForm()
        {
            InitializeComponent();
        }

        public void departmanOku()
        {
            ArrayList okunanlar = (new DepartmanBLL()).Departman_Listele();
            DepartmanList.Items.Clear();
            foreach (Departman okunan in okunanlar)
            {
                DepartmanList.Items.Add(okunan);
            }
        }
        private void ekleBtn_Click(object sender, EventArgs e)
        {
            int kat;
            if (!int.TryParse(katTxt.Text,out kat))
            {
                MessageBox.Show("Departman kat bilgisine sayısal değer giriniz. ");
                return;
            }
            bool kontrol = DepartmanBLL.DepartmanKontrol(adTxt.Text,
                                                             Convert.ToInt32(katTxt.Text),
                                                             iletisimTxt.Text);
            if (!kontrol)
            {
                MessageBox.Show(
                    "Departman bilgileri eksik veya hatalı!\n\n" +
                    "• Departman adı boş olamaz\n" +
                    "• Departman kat bilgisi 0'dan büyük olmalı\n" +
                    "• İletişim bilgisi girilmelidir",
                    "Uyarı");
                return;
            }

                        (new DepartmanBLL()).Departman_Ekle(adTxt.Text, Convert.ToInt32(katTxt.Text), iletisimTxt.Text,date.Value);
            departmanOku();
        }


        private void DepartmanForm_Load(object sender, EventArgs e)
        {
            departmanOku();

        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            if (DepartmanList.SelectedItem == null)
            {
                MessageBox.Show("Guncellemek istediğiniz departmanı seçiniz");
                return;
            }


            //Departman secilen = (Departman)DepartmanList.SelectedItem;
            int kat;
            if (!int.TryParse(katTxt.Text, out kat))
            {
                MessageBox.Show("Departman kat bilgisine sayısal değer giriniz. ");
                return;
            }
            bool kontrol = DepartmanBLL.DepartmanKontrol(adTxt.Text,
                                                            Convert.ToInt32(katTxt.Text),
                                                            iletisimTxt.Text);
            if (!kontrol)
            {
                MessageBox.Show(
                    "Departman bilgileri eksik veya hatalı!\n\n" +
                    "• Departman adı boş olamaz\n" +
                    "• Kat bilgisi 0'dan büyük olmalı\n" +
                    "• İletişim bilgisi girilmelidir",
                    "Uyarı");
                return;
            }
            (new DepartmanBLL()).Departman_Guncelle(((Departman)DepartmanList.SelectedItem).ID, adTxt.Text, Convert.ToInt32(katTxt.Text), iletisimTxt.Text,date.Value);
            departmanOku();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (DepartmanList.SelectedItem == null)
            {
                MessageBox.Show("Silmek istediğiniz departmanı seçiniz");
                return;
            }
             (new DepartmanBLL()).Departman_Sil(((Departman)DepartmanList.SelectedItem).ID);
            departmanOku();
        }

        private void DepartmanList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DepartmanList.SelectedItem == null) return;
            Departman d = (Departman)DepartmanList.SelectedItem;
            adTxt.Text = d.Adi.ToString();
            katTxt.Text = d.Kati.ToString();
            iletisimTxt.Text = d.Iletisim.ToString();
            date.Text= d.Tarih.ToString();

        }

        private void anaBtn_Click(object sender, EventArgs e)
        {
            AnaMenuForm anaForm = new AnaMenuForm();
            anaForm.Show();
            this.Close();
        }

        private void cıkısBtn_Click(object sender, EventArgs e)
        {
            OturumForm o = new OturumForm();
            o.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
