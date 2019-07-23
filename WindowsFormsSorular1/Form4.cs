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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        // 4) Ekrana 3 buton koy. Hangi butona tıklanırsa DİĞER butonlar 20 px sağa kaysın
        private void btnButon1_Click(object sender, EventArgs e)
        {
            btnButon2.Left = btnButon2.Left + 20;
            btnButon3.Left = btnButon3.Left + 20;
        }

        private void btnButon2_Click(object sender, EventArgs e)
        {
            btnButon1.Left = btnButon1.Left + 20;
            btnButon3.Left = btnButon3.Left + 20;
        }

        private void btnButon3_Click(object sender, EventArgs e)
        {
            btnButon1.Left += 20;
            btnButon2.Left += 20;
        }

    }
}
