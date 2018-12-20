using Hastane.Lib.Helpers;
using Hastane.Lib.Models;
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
    public partial class RandevuForm : Form
    {
        public RandevuForm()
        {
            InitializeComponent();
        }

        private void RandevuForm_Load(object sender, EventArgs e)
        {
            cmbServis.DataSource = Enum.GetNames(typeof(Servis));
            lstHastalar.DataSource = Form1.context.Hastalar
                .OrderBy(x => x.Ad)
                .ThenBy(x => x.Soyad)
                .ToList();
        }
        private Hasta seciliHasta;
        private Servis seciliServis;
        private Doktor seciliDoktor;
        private Button seciliButon;

        private void lstHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHastalar.SelectedItem==null)
            {
                return;
            }
            seciliHasta = lstHastalar.SelectedItem as Hasta;
            cmbServis.Visible = true;
        }

        private void txtAra_KeyUp(object sender, KeyEventArgs e)
        {
            lstHastalar.DataSource = KisiHelpers.Ara<Hasta>(Form1.context.Hastalar, txtAra.Text);
        }

        private void lstHastalar_KeyDown(object sender, KeyEventArgs e)
        {
            txtAra.Focus();
            txtAra.Text = e.KeyCode.ToString();
            txtAra.SelectionStart = 1;
        }

        private void cmbServis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
