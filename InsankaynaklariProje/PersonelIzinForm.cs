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
    public partial class PersonelIzinForm : Form
    {
        public PersonelIzinForm()
        {
            InitializeComponent();
        }
        public void izinOku()
        {

            int gId = Oturum.Pid;
            ArrayList okunanlar = (new IzinBLL()).BekleyenIzinler(gId);

            foreach (Izin okunan in okunanlar)
            {
                IzinList.Items.Add(okunan.Istenilen_gun + "gun| " + okunan.Durum + " | " + okunan.Neden);
            }
        }
        private void PersonelIzinForm_Load(object sender, EventArgs e)
        {
            izinOku();
        }

        private void talepBtn_Click(object sender, EventArgs e)
        {
            int kat;
            if (!int.TryParse(istenilenGunTxt.Text, out kat))
            {
                MessageBox.Show("Istenilen gün bilgisine sayısal değer giriniz. ");
                return;
            }
            bool kontrol = IzinBLL.IzinKontrol(aciklamaTxt.Text, Convert.ToInt32(istenilenGunTxt.Text));
            if (!kontrol)
            {
                MessageBox.Show(" Hatalı bilgi girişi yaptınız\n+"
                    + "İstenilen gün bilgisini ve açıklama bilgisini dogru giriniz");
                return;
            }
             
            int istenenGun = Convert.ToInt32(istenilenGunTxt.Text);
           
            int kullanilan = (new IzinBLL()).KalanGunHrsabi();
            if (istenenGun + kullanilan > 14)
            {
                MessageBox.Show("Yeterli izin hakkiniz bulunmamaktadir!");
            }

            (new IzinBLL()).Izın_talep(Convert.ToInt32(istenilenGunTxt.Text),
                                                                aciklamaTxt.Text);

            MessageBox.Show("İzin talebiniz basarıyla yöneticiye gönderilmiştir");
        }

        private void IzinList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void anaMenuBtn_Click(object sender, EventArgs e)
        {
            AnaMenuForm ana = new AnaMenuForm();
            ana.Show();
            this.Close();
        }

        private void cıkısBtn_Click(object sender, EventArgs e)
        {
            OturumForm oturum = new OturumForm();
            oturum.Show();
            this.Close();
        }
    }
}
