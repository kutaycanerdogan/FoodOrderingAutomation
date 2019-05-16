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
    public partial class SiparisFormu : Form
    {
        int _selectedIndex;

        public SiparisFormu()
        {
            InitializeComponent();

            foreach (Menu item in Program.Menuler)
            {
                cbMenuler.Items.Add(item);
            }
            cbMenuler.SelectedIndex = 0;
            foreach (Ekstra item in Program.Ekstralar)
            {
                flwLayout.Controls.Add(new CheckBox() { Text = item.EkstraAdi, Tag = item });
            }
        }
        decimal toplamTutar=0;
        public decimal ToplamTutar(decimal Tutar)
        {
            return toplamTutar += Tutar;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public void ListBoxGetir(int _selectedIndex)
        {
            Siparis SeciliSiparis =Program.Siparisler[_selectedIndex];
            cbMenuler.SelectedItem = SeciliSiparis.SeciliMenu;
            if (SeciliSiparis.Boyutu == Boyut.Kucuk)
            {
                rbKucuk.Checked = true;
            }
            else if (SeciliSiparis.Boyutu == Boyut.Orta)
            {
                rbOrta.Checked = true;
            }
            else
            {
                rbOrta.Checked = true;
            }
            for (int i = 0; i < SeciliSiparis.EkstraMalzemesi.Count; i++)
            {
                foreach (CheckBox item in flwLayout.Controls)
                {
                    if (SeciliSiparis.EkstraMalzemesi[i].EkstraAdi==item.Name)
                    {
                        item.Checked = true;
                    }
                }
            }
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("Toplam Tutar: "+lblTutar.Text,"Siparişi Onayla", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dr==DialogResult.Yes)
            {
                lstSiparis.Items.Clear();
                Program.Siparisler.Clear();
                MessageBox.Show("Siparişiniz Tamamlandı");
            }
            else
            {
                MessageBox.Show("Siparişiniz İptal Edildi");
            }
        }

        private void lstSiparis_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedIndex = lstSiparis.SelectedIndex;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Fonksiyonlar.KontrolTemizle(Form1.SiparisFormu.Controls);
        }
        

        private void btnSiparisFormuAnaMenuyeDon_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.Show();
        }

        private void btnSiparisEkleSiparisVer_Click(object sender, EventArgs e)
        {

            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenu = (Menu)cbMenuler.SelectedItem;
            if (rbKucuk.Checked)
            {
                yeniSiparis.Boyutu = Boyut.Kucuk;
            }
            else if (rbOrta.Checked)
            {
                yeniSiparis.Boyutu = Boyut.Orta;
            }
            else
            {
                yeniSiparis.Boyutu = Boyut.Buyuk;
            }
            yeniSiparis.EkstraMalzemesi = new List<Ekstra>();
            foreach (CheckBox item in flwLayout.Controls)
            {
                if (item.Checked)
                {
                    yeniSiparis.EkstraMalzemesi.Add((Ekstra)item.Tag);
                }
            }
            yeniSiparis.Adet = Convert.ToInt32(nmrAdet.Value);
            yeniSiparis.Hesapla();
            Program.Siparisler.Add(yeniSiparis);
            lstSiparis.Items.Add(yeniSiparis);
            toplamTutar = ToplamTutar(yeniSiparis.Tutar);
            lblTutar.Text = toplamTutar.ToString();
        }
    }
}
