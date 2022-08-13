using System;

namespace Yok_edici_fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        //bilgisayar adında bir class oluşturdum
        //yok edici fonksiyon sınıf ile işimiz bitince otomatik olarak çalışan fonksiyondur
        class bilgisayar
        {
            public string marka;

            public int fiyat;
            //bi bilgisayarın olamsı gereken bazı özelliklerini yapıcı fonksiyon olarak atadım
            public bilgisayar()
            {
                Console.WriteLine(marka);
                Console.WriteLine(fiyat);
            }
            //yazdığım verilere değer atadım 
           public void değeryaz()
            {
                marka = "hp";
                fiyat = 3700;
            }

            ~bilgisayar()
            {
                Console.WriteLine("bilgisayarnız sipariş listesine eklenmiştir");
            }
            
        }


    }
}
