using System;

namespace construction
{
    class Program
    {
        static void Main(string[] args)
        {
            //yapıcılar bir sınıf oluşturduğumuzda otomatik olarak çalışan fonksiyonlardır
            sınıf yeni = new sınıf();

            Console.WriteLine(yeni.ad);
            


        }
        //örnek oluşturdum
        class sınıf
        {
            public string ad;
            public string soyad;

           public sınıf()
            {
                ad = "ahmet";
                soyad = "keser";
            }
        }

    }
}
