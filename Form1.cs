using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerciProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static MenuEkle MenuEkle = new MenuEkle();
        public static SiparisFormu SiparisFormu = new SiparisFormu();
        public static EkstraEkle EkstraEkle = new EkstraEkle();


        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuEkle.Show();
            
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            this.Hide();
            SiparisFormu.Show();
        }

        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            EkstraEkle.Show();
        }
        
    }
}
