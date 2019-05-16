using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerciProje
{
    public class Siparis
    {
        public Menu SeciliMenu { get; set; }
        public Boyut Boyutu { get; set; }
        public List<Ekstra> EkstraMalzemesi { get; set; }
        
        public int Adet { get; set; }
        public decimal Tutar { get; set; }

        public void Hesapla()
        {
            Tutar += SeciliMenu.Fiyat;
            switch (Boyutu)
            {
                case Boyut.Orta:Tutar *= 1.1m;
                    break;
                case Boyut.Buyuk:Tutar*= 1.2m;
                    break;
            }

            foreach (Ekstra item in EkstraMalzemesi)
            {
                Tutar += item.Fiyati;
            }

            Tutar *= Adet;

        }
       
        public override string ToString()
        {
            string ekstraMalzemeler="";

            if (EkstraMalzemesi.Count > 1)
            {
                foreach (var item in EkstraMalzemesi)
                {
                    ekstraMalzemeler += item.EkstraAdi + " ";

                }
                ekstraMalzemeler= string.Format("{0} Menü ,{1} adet , {2} ,Ekstra Malzemeler: {3}, Toplam Tutar: {4}", SeciliMenu.MenuAdi, Adet, Boyutu, ekstraMalzemeler ,Tutar);
            }
            else
            {
                ekstraMalzemeler=string.Format("{0} Menü ,{1} adet , {2} , Toplam Tutar: {3}", SeciliMenu.MenuAdi, Adet, Boyutu, Tutar);
            }

            return ekstraMalzemeler;


        }
    }
}
