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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        // 8) Trafik lambası uygulaması.. Ekrana 3 buton koy. 
        //Bunlar trafik lambasındaki sarı, kırmızı ve yeşili temsil edecek. 
        // 4. buton ise start butonu olsun. Start butonuna bastığında ekrandaki butonlar trafik lambasındaki gibi belirli saniyelerle sarı-kırmızı ve yeşil olsun.


        int sn = 10;
        int durum = 3;

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

            if (durum == 3)
            {
                sn--;

                if (sn == 0)
                {
                    durum = 2;
                    btnRed.BackColor = Color.Empty;

                    btnYellow.BackColor = Color.Yellow;
                    sn = 2;
                }

            }


            else if (durum == 2)
            {
                sn--;

                if (sn == 0)
                {
                    durum = 1;
                    btnYellow.BackColor = Color.Empty;
                    btnGreen.BackColor = Color.Green;
                    sn = 5;
                }
            }

            else if (durum == 1)
            {
                sn--;

                if (sn == 0)
                {
                    durum = 3;
                    btnGreen.BackColor = Color.Empty;
                    btnRed.BackColor = Color.Red;
                    sn = 10;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnRed.BackColor = Color.Red;
            timer1.Start();
        }
    }

}