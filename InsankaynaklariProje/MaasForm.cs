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
    public partial class MaasForm : Form
    {
        public MaasForm()
        {
            InitializeComponent();
        }
        public void maas_oku()
        {
            ArrayList okunanlar = new MaasBLL().Maas_List();
            MaasList.Items.Clear();
            foreach (Maas okunan in okunanlar)
            {
                MaasList.Items.Add(okunan);
            }
        }
        private void MaasForm_Load(object sender, EventArgs e)
        {
            maas_oku();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            

            int pId;
            double net, brut, kesinti, bonus;

            if (!int.TryParse(pidTxt.Text, out pId))
            {
                MessageBox.Show("Personel ID sayısal olmalıdır");
                return;
            }
            if(!double.TryParse(netTxt.Text, out net))
            {
                MessageBox.Show("Net maaş bilgisi sayısal olmalıdır");
                return;
            }
            if(!double.TryParse(bonusTxt.Text, out bonus))
            {
                MessageBox.Show("Bonus bilgisi sayısal olmalıdır");
                return;
            }
            if(!double.TryParse(brutTxt.Text, out brut))
            {
                MessageBox.Show("Brut maaş bilgisi sayısal olmalıdır");
                return;

            }
            if(!double.TryParse(kesintiTxt.Text, out kesinti))
            {
                MessageBox.Show("Kesinti bilgisi sayisal olmalıdır");
                return;
            }
                bool kontrol = MaasBLL.MaasKontrol(Convert.ToInt32(pidTxt.Text), Convert.ToDouble(brutTxt.Text), Convert.ToDouble(netTxt.Text), Convert.ToDouble(kesintiTxt.Text), Convert.ToDouble(bonusTxt.Text));

            if (!kontrol)
            {
                MessageBox.Show("Maas bilgileri eksik veya hatalı!\n\n" +
                    "• Personel ID 0'dan büyük olmalı \n" +
                    "• Brut maaş bilgisi 0'dan büyük olmalı\n" +
                    "• Net maaş bilgisi 0'dan büyük olmalı\n"+
                    "• Bonus bilgisi 0'dan büyük olmalı\n"+
                    "• Kesinti bilgisi 0'dan büyük olmalı\n");
                return;
            }
            (new MaasBLL()).Maas_Ekle(Convert.ToInt32(pidTxt.Text), Convert.ToDouble(brutTxt.Text), Convert.ToDouble(bonusTxt.Text),
                                             Convert.ToDouble(kesintiTxt.Text), Convert.ToDouble(netTxt.Text),odemeDate.Value, olusturmaDate.Value);
            maas_oku();


        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (MaasList.SelectedItem == null)
            {
                MessageBox.Show("Silmek istediginiz maasi seciniz");
                return;
            }

           (new MaasBLL()).Maas_Sil(((Maas)MaasList.SelectedItem).Id);
            maas_oku();
        }

        private void guncelleTxt_Click(object sender, EventArgs e)
        {
            if (MaasList.SelectedItem == null)
            {
                MessageBox.Show("Guncellemek istediginiz maasi seciniz");
                return;
            }
           
            
            int pId;
            double net, brut, kesinti, bonus;

            if (!int.TryParse(pidTxt.Text, out pId))
            {
                MessageBox.Show("Personel ID sayısal olmalıdır");
                return;
            }
            if (!double.TryParse(netTxt.Text, out net))
            {
                MessageBox.Show("Net maaş bilgisi sayısal olmalıdır");
                return;
            }
            if (!double.TryParse(bonusTxt.Text, out bonus))
            {
                MessageBox.Show("Bonus bilgisi sayısal olmalıdır");
                return;
            }
            if (!double.TryParse(brutTxt.Text, out brut))
            {
                MessageBox.Show("Brut maaş bilgisi sayısal olmalıdır");
                return;

            }
            if (!double.TryParse(kesintiTxt.Text, out kesinti))
            {
                MessageBox.Show("Kesinti bilgisi sayisal olmalıdır");
                return;
            }
            bool kontrol = MaasBLL.MaasKontrol(Convert.ToInt32(pidTxt.Text), Convert.ToDouble(brutTxt.Text), Convert.ToDouble(netTxt.Text), Convert.ToDouble(kesintiTxt.Text), Convert.ToDouble(bonusTxt.Text));

            if (!kontrol)
            {
                MessageBox.Show("Maas bilgileri eksik veya hatalı!\n\n" +
                    "• Personel ID 0'dan büyük olmalı \n" +
                    "• Brut maaş bilgisi 0'dan büyük olmalı\n" +
                    "• Net maaş bilgisi 0'dan büyük olmalı\n" +
                    "• Bonus bilgisi 0'dan büyük olmalı\n" +
                    "• Kesinti bilgisi 0'dan büyük olmalı\n");
                return;
            }
            (new MaasBLL()).Maas_Guncelle(((Maas)MaasList.SelectedItem).Id, Convert.ToInt32(pidTxt.Text), Convert.ToInt32(brutTxt.Text), Convert.ToInt32(bonusTxt.Text), Convert.ToInt32(kesintiTxt.Text),
                                            Convert.ToInt32(netTxt.Text), odemeDate.Value,olusturmaDate.Value );
            maas_oku();
        }

        private void MaasList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MaasList.SelectedItem == null) return;

            Maas m = (Maas)MaasList.SelectedItem;

            pidTxt.Text = m.PID.ToString();
            brutTxt.Text = m.Brut.ToString();
            bonusTxt.Text = m.Bonus.ToString();
            kesintiTxt.Text = m.Kesinti.ToString();
            netTxt.Text = m.Net.ToString();

            odemeDate.Text = m.Odeme_tarih.ToString();
            olusturmaDate.Text = m.Olusturma_tarih.ToString();
        }

        private void anaMenuBnt_Click(object sender, EventArgs e)
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
