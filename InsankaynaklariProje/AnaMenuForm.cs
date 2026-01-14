using InsankaynaklariProje.BLL;
using InsankaynaklariProje.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
namespace InsankaynaklariProje
{
    public partial class AnaMenuForm : Form
    {
        public AnaMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!YetkiBLL.YetkisiVarMi("Personel"))
            {
                MessageBox.Show("Bu işlem için yetkiniz yok!");
                return;
            }
          
            PersonelForm f = new PersonelForm();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!YetkiBLL.YetkisiVarMi("Departman"))
            {
                MessageBox.Show("Bu işlem için yetkiniz yok!");
                return;
            }
           
            DepartmanForm d = new DepartmanForm();
            d.Show();
            this.Close();
        }

        private void izinAlBtn_Click(object sender, EventArgs e)
        {
            PersonelIzinForm i = new PersonelIzinForm();
            i.Show();
            this.Close();
        }

        private void maasBtn_Click(object sender, EventArgs e)
        {
            
            if (!YetkiBLL.YetkisiVarMi("Maas"))
            {
                MessageBox.Show("Bu işlem için yetkiniz yok!");
                return;
            }
            MaasForm m = new MaasForm();
            m.Show();
            this.Close();
        }

        private void performansBtn_Click(object sender, EventArgs e)
        {
            if (!YetkiBLL.YetkisiVarMi("Performans"))
            {
                MessageBox.Show("Bu işlem için yetkiniz yok!");
                return;
            }
           
            PerformansForm prf = new PerformansForm();
            prf.Show();
            this.Close();
        }

        private void izinOnayBtn_Click(object sender, EventArgs e)
        {
            if (!YetkiBLL.YetkisiVarMi("IzinOnay"))
            {
                MessageBox.Show("Bu işlem için yetkiniz yok!");
                return;
            }
            
            YoneticiIzinForm f = new YoneticiIzinForm();
            f.Show();
            this.Close();
        }

        private void cıkısBtn_Click(object sender, EventArgs e)
        {
            OturumForm form = new OturumForm();
            form.Show();
            this.Close();
        }

        private void raporlaBtn_Click(object sender, EventArgs e)
        {
            if (!YetkiBLL.YetkisiVarMi("Rapor"))// !: yetkisi yoksa anlamında / değil 
            {
                MessageBox.Show("Bu işlem için yetkiniz yok!");
                return;
            }
          
            RaporForm r = new RaporForm();
            r.Show();
            this.Close();
        }

        private void AnaMenuForm_Load(object sender, EventArgs e)
        {
            if (Oturum.Gorev == "Yonetici")
            {
                MessageBox.Show(
                    "Bilgilendirme:\n\n" +
                    "İzin talepleri günlük olarak değerlendirilmektedir.\n" +
                    "Sistemde izinler başlangıç ve bitiş tarihi olmadan,\n" +
                    "günlük talep mantığıyla kaydedilmektedir.",
                    "Yönetici Bilgilendirmesi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
