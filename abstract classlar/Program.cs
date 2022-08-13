using System;

namespace abstract_classlar
{
    class Program
    {
        //soyut sınıfların özelliği nesne oluşturmamasıdır 
        //soyut sınıfları sadece kalıtım amacıyla kullanılır
        static void Main(string[] args)
        {
            mobilya ahmet = new mobilya();
            //görüyorsunuz mobilya abstract olduğu için new komutu ile nesne oluşturamadım sadece kalıtım alma amacıyla kullandım

        }
        //abstact olarak mobilya sınıfını oluşturdum
        abstract class mobilya
        {
            //abstract tipinde ozellikyaz metodunu oluşturdum
            public string renk;
            abstract public void ozellikyaz();
        }
        //mobilya abstact sınıfı sadece kalıtım verebilir  new komutu ile nesne oluşturulamaz
        class dolap: mobilya
        {
            public string malzeme;
            public override void ozellikyaz()
            {
                Console.WriteLine("dolabın Özellikleri");
                Console.WriteLine("Renk: {0}", renk);
                Console.WriteLine("Kumaş: {0}", malzeme);
            }
        }

      


    }
}
