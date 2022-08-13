using System;

namespace out_bildirili_prosedür
{
    class Program
    {
        static void Main(string[] args)
        {
            //out keywordundde başlangıç değerini belirtilmesine gerek yokturk
            //8 değerini y ye atadım
            int y = 8;
            Console.WriteLine(y);
            //out keyword kullanarak bellek kopyalama sorununu aşıp
            //değeri 40 olarak değiştirdim
            değiştir(out y);
            //kontrol etmek amacıyla bastırdım
            Console.WriteLine(y);

        }

        // burada out keywordlu bir prosedür oluşturdum
        static void değiştir(out int b)
        {
            b = 40;
        }

    }
}
