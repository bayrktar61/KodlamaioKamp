using System;

namespace ClassOlusturma
{
    class Program
    {
        static void Main(string[] args)
        {
            Takim takim1 = new Takim();
            takim1.marka = "Checkmate";
            takim1.urunadi = "Ahşap Satranç Takımı";
            takim1.urunkodu = "A1456k";
            takim1.fiyat = "150TL";
            
            Takim takim2 = new Takim();
            takim2.marka = "Blackburry";
            takim2.urunadi = "Cam Satranç Takımı";
            takim2.urunkodu = "S9286y";
            takim2.fiyat = "185TL";
                
            Takim [] takimlar = new Takim[] { takim1, takim2 };
            Console.WriteLine("-Foreach Döngüsü-");
           
            foreach (var Takim in takimlar)
            {
                Console.WriteLine("\n"+Takim.marka + " " + Takim.urunadi + " " + Takim.urunkodu + " " + Takim.fiyat);
            }
            Console.WriteLine("\n-For Döngüsü-");
            for (int a = 0; a < takimlar.Length; a++)
            {
                Console.WriteLine("\n"+takimlar[a].marka + " " + takimlar[a].urunadi + " " + takimlar[a].urunkodu + " " + takimlar[a].fiyat);
            }
            Console.WriteLine("\n-While Döngüsü-");
            int b=0 ;
            while (b < takimlar.Length)
            {
                Console.WriteLine("\n"+takimlar[b].marka + " " + takimlar[b].urunadi + " " + takimlar[b].urunkodu + " " + takimlar[b].fiyat);
                b++;
            }

        }
    }
     class Takim
    {
        public string marka { get; set; }
        public string urunadi { get; set; }
        public string urunkodu { get; set; }
        public string fiyat { get; set; }
    }
}
