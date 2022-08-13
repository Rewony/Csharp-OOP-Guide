using System;

namespace klass_içerisinde_prosedür_oluşturmak
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ahmet master = new ahmet();
            //a ya değer atadım
            master.a = "selam";
            //yazdırdım
            master.mesajıgöster();

        }

        class ahmet
        {
            //a tipinde bir değişken oluştudum
            public string  a;
            //mesajıgöster adında bir prosedürüm var
            public void mesajıgöster()
            {
                //burdada yazdırdım
                
                Console.WriteLine(a);

            }

        }
    }
}
