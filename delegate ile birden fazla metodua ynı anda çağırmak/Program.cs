using System;

namespace delegate_ile_birden_fazla_metodua_ynı_anda_çağırmak
{

    delegate int Dikdörtgen(int x, int y);


    class Program
    {
        //delegateler methodların pointeridir method adreslerini tutarlar
        static void Main(string[] args)
        {
            Dikdörtgen yeni =new  Dikdörtgen(çevre);
            yeni += alan;
            Console.WriteLine(yeni(4, 5));
            //burada yeni objesine çevre metodnuda ekleyip 
            //birden fazla method çağırmış olduk
        }


        public int çevre(int a, int b)
        {
            return 2 * (a + b);
        }

        public int alan(int a, int b)
        {

            return a * b;
        }
    }

  



}
