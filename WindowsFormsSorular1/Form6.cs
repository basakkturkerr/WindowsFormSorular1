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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        // 6) Bir login ekranı tasarla. Kullanıcı adı “a@a.com" ve şifre “123” ise; 
        //formdaki elementleri REMOVE et ve ekrana “İşlem başarılı” yazdır. 
        //Değilse “Kullanıcı adı veya şifre hatalı” yazdır

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string Email = txtAd.Text;
            string Sifre = txtSifre.Text;

            if (Email == "a@a.com" && Sifre == "123")
            {
                MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }

            txtAd.Text = "";
            txtSifre.Text = "";
        }
    }
}
