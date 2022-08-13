using System;

namespace kalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
            //kalıtım bir classın başka classın elemanlarının kullanabilmesidir
           
            şilep yeni = new şilep();
            //şilep nesnesi üzerinden tekne nesnesinin elemanlrına ulaşabildim
            yeni.değergir(4, 6);
            //aynı zamanda şilep elemanlarınada ulaşabildim
            yeni.ticarilisanstipi = "kuruyük";

        }

        class tekne
        {
            //tekne sınıfına bağlı veriler oluştudum
            
            public int uzunluk;
            public int motorgücü;
            //değerlere veri atayabilmek için burada bir prosedür yazdım
            public void değergir(int a,int b)
            {
                uzunluk = a;

                motorgücü = b;
            }
        }
        // burada şilep sınıfın tekneden kalıtım aldırdım bu sayede şilep teknenin elemanlarına ulaşabilicek
        class şilep : tekne
        {
            //maks yük değiştirilemesin diye const olarak atadım
            public const int makskargoyükümiktarı = 40;
            public string ticarilisanstipi;
            //burda değer atamak için prosedür kullandım
            public void değergir()
            {
                ticarilisanstipi = Console.ReadLine();
                
            }

        }

    }
}
