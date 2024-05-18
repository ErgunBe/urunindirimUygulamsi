using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ürün
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // klavyeden iki ürün fiyatı girildigine toplam fiyat 200 den fazla ise 2.üründe %25 indirim yaparak ödenecek tutarı göstern uygulma
            Console.Write("Lütfen birinci ürünü girin: ");
            int birinciÜürünFiyati = int.Parse(Console.ReadLine());

            Console.Write("lütfen 2.ürün fiyatını girin: ");
            int ikinciÜrünFiyati = int.Parse(Console.ReadLine());

           

            if (birinciÜürünFiyati + ikinciÜrünFiyati > 200)
            {
                //int toplamSonTutar = birinciÜürünFiyati + (ikinciÜrünFiyati * 75 / 100);
                Console.WriteLine(birinciÜürünFiyati + (ikinciÜrünFiyati * 75 / 100));
                
            }
            Console.ReadLine();
        }
    }
}
