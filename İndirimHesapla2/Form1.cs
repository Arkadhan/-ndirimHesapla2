using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İndirimHesapla2
{
    public partial class Form1 : Form
    {
        double fiyat;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn10_Click(object sender, EventArgs e)
        {

            fiyat = Convert.ToDouble(tbFiyat.Text);
            lbİndFiyat.Text = Convert.ToString(fiyat - (fiyat * 10 / 100));
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            fiyat = Convert.ToDouble(tbFiyat.Text);
            lbİndFiyat.Text = Convert.ToString(fiyat - (fiyat * 25 / 100));
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            fiyat = Convert.ToDouble(tbFiyat.Text);
            lbİndFiyat.Text = Convert.ToString(fiyat - (fiyat * 50 / 100));
        }

        private void btn75_Click(object sender, EventArgs e)
        {
            fiyat = Convert.ToDouble(tbFiyat.Text);
            lbİndFiyat.Text = Convert.ToString(fiyat - (fiyat * 75 / 100));
        }
    }
}
