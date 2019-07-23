using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSorular1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       // 2) 3 ayrı textboxtan girilen sayıların ortalamasını bir label a yaz
        private void btnOrtalama_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);
            double sayi3 = Convert.ToDouble(txtSayi3.Text);

            double ortalama = (sayi1 + sayi2 + sayi3) / 3;

            lblSonuc.Text = ortalama.ToString();
        }

    }
}

