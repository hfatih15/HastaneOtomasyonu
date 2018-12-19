using Hastane.Lib.Data;
using System;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DoktorEkleForm frmDoktor;
        private RandevuForm frmRandevu;
        private RandevuRaporForm frmRandevuRaporForm;
        public static Context context { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new MockData().context;
        }

        private void doktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDoktor==null || frmDoktor.IsDisposed)
            {
                frmDoktor = new DoktorEkleForm {
                    Text = "Doktor Formu",
                    MdiParent=this

                };
                frmDoktor.Show();
            }
        }

        private void randevuAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRandevu == null || frmRandevu.IsDisposed)
            {
                frmRandevu = new RandevuForm
                {
                    Text = "Randevu Formu",
                    MdiParent = this

                };
                frmRandevu.Show();
            }
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRandevuRaporForm == null || frmRandevuRaporForm.IsDisposed)
            {
                frmRandevuRaporForm = new RandevuRaporForm
                {
                    Text = "Randevu rapor Formu",
                    MdiParent = this

                };
                frmRandevuRaporForm.Show();
            }
        }
    }
}
