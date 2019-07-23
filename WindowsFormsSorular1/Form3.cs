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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // 3) Ekrandaki butonu her tıkladığında tıklanılan butonu 20 px sağa kaydır

        private void btnButon_Click(object sender, EventArgs e)
        {
            btnButon.Left = btnButon.Left + 20;
        }
    }
}
