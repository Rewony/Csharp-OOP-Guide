using System;

namespace class_içerisinde_fonksiyonlar_oluşturmak
{
    class Program
    {
        //class içerisindeki değerlerin içerisinde işlem yapmaya yarayan yapılardır
        static void Main(string[] args)
        {
            //sınıftan eleman türettim
            C üye = new C();
            //değerler atadım
            üye.a = 19;
            üye.c = "ahmet";
            //fonsiyonu çalıştırdım
            üye.yazdir();
           
        }

        //sınıf oluşturdum
        class C
        {
            //sınıf için değerler oluşturdum
            public int a;
            public string c;
            //burada fonksiyon oluşturdu
            //sınıfın elemanlarına fonksiyon içirisinde değerler verdim
            public void yazdir()
            {
                
                Console.WriteLine("yaşı:",a);
                Console.WriteLine("adınız:",c);

            }



        }





    }
}
