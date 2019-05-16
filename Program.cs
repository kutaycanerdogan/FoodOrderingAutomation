using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerciProje
{
    public static class Program
    {
        public static Form1 form1;
        public static List<Siparis> Siparisler = new List<Siparis>();

        public static List<Menu> Menuler = new List<Menu>()
        {
            new Menu {MenuAdi="SteakHouse",Fiyat=18.25m},
            new Menu {MenuAdi="McFish",Fiyat=8},
            new Menu {MenuAdi="Whooper",Fiyat=12},
            new Menu {MenuAdi="BigKing",Fiyat=13.75m},
            new Menu {MenuAdi="ChikenRoyal",Fiyat=11}

        };

        public static List<Ekstra> Ekstralar = new List<Ekstra>()
        {
            new Ekstra {EkstraAdi="Hardal",Fiyati=0.5m},
            new Ekstra {EkstraAdi="Ketçap",Fiyati=0.5m},
            new Ekstra {EkstraAdi="Mayonez",Fiyati=0.5m},
            new Ekstra {EkstraAdi="Ranch",Fiyati=1},
            new Ekstra {EkstraAdi="Buffalo",Fiyati=1},
            new Ekstra {EkstraAdi="AcıSos",Fiyati=0.5m},
            new Ekstra {EkstraAdi="Soğan Halkası(12'li)",Fiyati=6},
            new Ekstra {EkstraAdi="Soğan Halkası(8'li)",Fiyati=4},
            new Ekstra {EkstraAdi="Nugget(6'lı)",Fiyati=6m},
            new Ekstra {EkstraAdi="Nugget(4'lı)",Fiyati=4m},
        };
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            form1 = new Form1();
            Application.Run(form1);

    }
    }
}
