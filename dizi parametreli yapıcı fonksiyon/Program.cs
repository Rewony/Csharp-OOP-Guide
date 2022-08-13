using System;

namespace dizi_parametreli_yapıcı_fonksiyon
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array = new string[5];
            //parametreli yapıcımı çağıtrmak için parametreli halde oluşturdum
            okyanus cis = new okyanus(array);
            cis.tuz = 12;

            Console.WriteLine(cis.isimler[0]);

        }

        class okyanus
        {

            public int tuz;
          public  string[] isimler = new string[4];
            //parametre olarak dizi verdim birden fazla yapıcı fonk yazdığım gibi
            public okyanus(string[] isim)
            {
                isim[0] = "atlas okyanusu";

                isim[1] = "büyük okyanus";

                isim[2] = "hint okyanusu";

                isim[3] = "güney okyanusu";
                //yapıcı içerisinde oluşturduğum diziye sabit elemanlar atadım bunlarıda public olan class elemanına for döngüsü ile atadım
                for(int i = 0; i <=5; i++)
                {
                    isimler[i] = isim[i];

                }

            }

        }

    }
}
