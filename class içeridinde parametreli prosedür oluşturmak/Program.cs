using System;

namespace class_içeridinde_parametreli_prosedür_oluşturmak
{
    class Program
    {
        //prosedürler değer döndürmeyen fonksiyonlardır
        static void Main(string[] args)
        {
            mehmet a = new mehmet();
            a.sayıdeğerata(4);
            //prosedürü kullandım
        }

        class mehmet
        {
            //class oluşturdum
            //değer oluşturdum
            public int a;
            //burada parametreli prosedür kullanarak değer atadım
            public void sayıdeğerata(int b)
            {

                a = b;

            }
        }

    }
}
