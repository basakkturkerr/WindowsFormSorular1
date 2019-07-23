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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1)  Textbox dan girilen sayıyın karesini başka bir textbox a yazdır

        private void btnKare_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtSayi.Text);

            double sonuc = sayi * sayi;
            txtSonuc.Text = sonuc.ToString();
        }

    }
}
