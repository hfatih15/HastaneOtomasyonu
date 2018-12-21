using Hastane.Lib.Helpers;
using Hastane.Lib.Models;
using Hastane.Lib.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class RandevuRaporForm : Form
    {
        public RandevuRaporForm()
        {
            InitializeComponent();
        }
        private void RandevuRaporForm_Load(object sender, EventArgs e)
        {
            cmbDoktorlar.DataSource = Form1.context.Doktorlar.OrderBy(x => x.Ad).ThenBy(x => x.Soyad).ToList();
        }
        private void cbmDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoktorlar.SelectedItem==null)
            {
                return;
            }
            Doktor seciliDoktor = cmbDoktorlar.SelectedItem as Doktor;
            dgvRandevu.DataSource = Form1.context.Randevular
                .Where(x => x.Doktor.Id == seciliDoktor.Id)
                .OrderBy(x => x.Saat)
                .Select(x => new RandevuViewModel()
                {
                    Doktor = x.Doktor.ToString(),
                    Hasta = x.Hasta.ToString(),
                    Poliklinik = x.Doktor.Servis.ToString(),
                    Saat = RandevuHelper.Saatler[x.Saat]
                })
                .ToList();
                

        }

       
    }
}
