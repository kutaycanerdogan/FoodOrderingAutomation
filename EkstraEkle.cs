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
    public partial class EkstraEkle : Form
    {
        public EkstraEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DialogResult dr = DialogResult.Yes;
            do
            {
                if (txtMenuAdi.Text != "" || txtMenuAdi.Text != null)
                {
                    Program.Ekstralar.Add(new Ekstra { EkstraAdi = txtMenuAdi.Text, Fiyati = nmrMenuFiyati.Value });
                }
                dr = MessageBox.Show("İşleminiz Başarıyla Gerçekleşti. Tekrar Ekstra Eklemek İster Misiniz?",
                "Ana Menüye Dön?", MessageBoxButtons.YesNo);
            } while (dr == DialogResult.Yes);
            
            this.Close();
            Program.form1.Show();
        }
    }
}
