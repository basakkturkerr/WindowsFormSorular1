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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        // 5) Ekrana bir text box bir buton koy. Textbox a girilen sayı kadar FORM genişlesin

        private void btnGenislet_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtBoy.Text);
            this.Width += sayi; 
        }

    }
}
