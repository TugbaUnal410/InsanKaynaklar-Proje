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
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();
        }
        public void personelOku()
        {
            ArrayList okunanlar = (new PersonelBLL()).Personel_List();
            PersonelList.Items.Clear();
            foreach (Personel okunan in okunanlar)
            {
                PersonelList.Items.Add(okunan);
            }
        }
        private void PersonelForm_Load(object sender, EventArgs e)
        {
            personelOku();
            DepartmanBLL d = new DepartmanBLL();
            didComboBox.DataSource = d.Departman();
            didComboBox.DisplayMember = "Adi";
            didComboBox.ValueMember = "ID";
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            
            bool kontrol = PersonelBLL.PersonelKontrol(adTxt.Text, soyadTxt.Text, telTxt.Text, Convert.ToInt32(didComboBox.SelectedValue), pozisyonTxt.Text);
            if (!kontrol)
            {
                MessageBox.Show("Personel bilgileri eksik veya hatalı girildi\n\n" +
                     "• Personel ad bilgisi boş olmamalı \n" +
                    "• Personel soyadı bilgisi boş olmamalı \n" +
                    "• Personel telefon bilgisi boş olmamalı \n" +
                    "• Departman seçimi yapılmalı \n" +
                    "• Personel pozisyon bilgisi boş olmamalı \n");
                return;

            }
            (new PersonelBLL()).Personel_Ekle(adTxt.Text, soyadTxt.Text, Convert.ToInt32(didComboBox.SelectedValue), pozisyonTxt.Text,baslangicDate.Value,
                                                 telTxt.Text, epostaTxt.Text, olusturmaDate.Value);
            personelOku();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (PersonelList.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silinecek personeli seçin");
                return;
            }
            (new PersonelBLL()).Personel_Sil(((Personel)PersonelList.SelectedItem).Id);
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
           
            bool kontrol=PersonelBLL.PersonelKontrol(adTxt.Text,soyadTxt.Text,telTxt.Text,Convert.ToInt32(didComboBox.SelectedValue),pozisyonTxt.Text);
            if(!kontrol)
            {
                MessageBox.Show("Personel bilgileri eksik veya hatalı girildi\n\n" +
                     "• Personel ad bilgisi boş olmamalı \n" +
                    "• Personel soyadı bilgisi boş olmamalı \n" +
                    "• Personel telefon bilgisi boş olmamalı \n" +
                    "• Departman seçimi yapılmalı \n" +
                    "• Personel pozisyon bilgisi boş olmamalı \n");
                return;

            }
            (new PersonelBLL()).Personel_Guncelle(((Personel)PersonelList.SelectedItem).Id, adTxt.Text, soyadTxt.Text, Convert.ToInt32(didComboBox.SelectedValue), pozisyonTxt.Text, baslangicDate.Value,
                                       telTxt.Text, epostaTxt.Text, olusturmaDate.Value);
            personelOku();
        }

        private void PersonelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PersonelList.SelectedItem == null) return;
            Personel p = (Personel)PersonelList.SelectedItem;
            adTxt.Text = p.Ad.ToString();
            soyadTxt.Text = p.Soyad.ToString();
            didComboBox.Text = p.Did.ToString();
            pozisyonTxt.Text = p.Pozisyon.ToString();
            baslangicDate.Text = p.Baslangic_tarih.ToString();
            telTxt.Text = p.Tel.ToString();
            epostaTxt.Text = p.Eposta.ToString();
            olusturmaDate.Text = p.OLusturulan_Tarih.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void anaBtn_Click(object sender, EventArgs e)
        {
            AnaMenuForm anaForm = new AnaMenuForm();
            anaForm.Show();
            this.Close();
        }

        private void cıkısBtn_Click(object sender, EventArgs e)
        {
            OturumForm oturumForm = new OturumForm();
            oturumForm.Show();
            this.Close();
        }
    }

}
