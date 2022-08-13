using System;

namespace event_oluşturmak
{
    //delegate yapımı burada oluşturdum
    delegate void deney();


    class Program
    {
        //eventi burada ekledim
        static event deney a;
        static void Main(string[] args)
        {
            //a eventine deneme methodunu ekledim
            a += Deneme;
            a();
        }
        //event keywords delegate anahtar kelimesi ile 
        //değişkenin olay olduğunu açıkça belirtmek için kullanılan anahtar kelimedir

        static void Deneme()
        {
            int sonuc = 12 + 4;
            Console.WriteLine(sonuc);

        }



    }
}
