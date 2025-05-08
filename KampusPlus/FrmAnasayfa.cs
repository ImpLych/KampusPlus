using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KampusPlus
{
    public partial class FrmAnasayfa: Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            FrmKulupler fr = new FrmKulupler();
            fr.Show();
            this.Hide();
        }

        private void BtnAnasayfa_Click(object sender, EventArgs e)
        {
            FrmAnasayfa fr = new FrmAnasayfa();
            fr.Show();
            this.Hide();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            fr.Show();
            this.Hide();
        }

        private void LblYaklasanEtkinlik_Click(object sender, EventArgs e)
        {
            FrmYaklasanEtkinlikler fr = new FrmYaklasanEtkinlikler();
            fr.Show();
            this.Hide();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FrmAnasayfa2 fr = new FrmAnasayfa2();
            fr.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

