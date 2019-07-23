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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        // 7) Ekrana 5 adet text box koy.  Girilen notların ortalamasını yıl sonu notu olarak mesaj olarak göster. 
        //(örneğin ortalama 32 ise not 1)

        private void btnHesap_Click(object sender, EventArgs e)
        {
            double not1 = Convert.ToDouble(txtNot1.Text);
            double not2 = Convert.ToDouble(txtNot2.Text);
            double not3 = Convert.ToDouble(txtNot3.Text);
            double not4 = Convert.ToDouble(txtNot4.Text);
            double not5 = Convert.ToDouble(txtNot5.Text);

            double ortalama = (not1 + not2 + not3 + not4 + not5) / 5;

            if (ortalama > 0 && ortalama < 25)
            {
                MessageBox.Show("Yıl Sonu Nutunuz: 0");
            }

            else if (ortalama >= 25 && ortalama < 45 )
            {
                MessageBox.Show("Yıl Sonu Notunuz: 1");     
            }

            else if (ortalama >= 45 && ortalama < 55 )
            {
                MessageBox.Show("Yıl Sonu Notunuz: 2");
            }

            else if (ortalama >= 55 && ortalama < 70 )
            {
                MessageBox.Show("Yıl Sonu Notunuz: 3");
            }

            else if ( ortalama >= 70 && ortalama <85 )
            {
                MessageBox.Show("Yıl Sonu Notunuz: 4");
            }

            else
            {
                MessageBox.Show("Yıl Sonu Notunuz: 5");
            }
        
        }

    }
}
