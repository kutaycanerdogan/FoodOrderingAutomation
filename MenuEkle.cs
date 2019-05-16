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
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DialogResult dr = DialogResult.Yes;
            if (dr == DialogResult.Yes)
            {
                if (txtMenuAdi.Text != "" || txtMenuAdi.Text != null)
                {
                    Program.Menuler.Add(new Menu { MenuAdi = txtMenuAdi.Text, Fiyat = nmrMenuFiyati.Value });
                    dr = MessageBox.Show("İşleminiz Başarıyla Gerçekleşti. Tekrar Menü Eklemek İster Misiniz?",
                    "Ana Menüye Dön?", MessageBoxButtons.YesNo);
                }
                else
                {
                    dr = MessageBox.Show("Hatalı Giriş Yaptınız!. Tekrar Denemek İster Misiniz?",
                    "Ana Menüye Dön?", MessageBoxButtons.YesNo);
                }
                Fonksiyonlar.KontrolTemizle(Form1.MenuEkle.Controls);
            }
            else
            {
                this.Close();
                Program.form1.Show();
            }
        }

        private void btnMenuEkleAnaMenuyeDon_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.Show();

        }
    }
}
