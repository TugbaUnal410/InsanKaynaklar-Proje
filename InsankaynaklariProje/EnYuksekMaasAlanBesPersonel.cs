using InsankaynaklariProje.BLL;
using System;
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
    public partial class EnYuksekMaasAlanBesPersonel : Form
    {
        public EnYuksekMaasAlanBesPersonel()
        {
            InitializeComponent();
        }

        private void EnYuksekMaasAlanBesPersonel_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                ayCombo.Items.Add(i.ToString());

            }
            for (int i = 2020; i <= 2026; i++)
            {
                yilCombo.Items.Add(i.ToString());
            }
        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt32(ayCombo.SelectedItem);
            int yil = Convert.ToInt32(yilCombo.SelectedItem);
            veri.DataSource = (new RaporBLL()).EnYuksekBesMaas(ay, yil);
        }

        private void raporBtn_Click(object sender, EventArgs e)
        {
            RaporForm form = new RaporForm();
            form.Show();
            this.Close();


        }

        private void anaMenuBtn_Click(object sender, EventArgs e)
        {
            AnaMenuForm form = new AnaMenuForm();
            form.Show();
            this.Close();
        }

        private void cıkısBtn_Click(object sender, EventArgs e)
        {
            OturumForm form = new OturumForm();
            form.Show();
            this.Close();
        }
    }
}
