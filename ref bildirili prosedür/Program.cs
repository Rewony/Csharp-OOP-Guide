using System;

namespace ref_bildirili_prosedür
{
    class Program
    {
        //ref keywordünde başlangıç değeri vermemiz gerekir
        //onun dışında out ile tamamne aynı işlevi gerçekleştirir
        static void Main(string[] args)
        {
            //burada değerler oluşturup prosedürü kullandım
            int number = 1;
            prosedur(ref number);
            Console.WriteLine(number);
        }

        //ref keyword içeren bir prosedür oluşturdum
      public void prosedur(ref int a)
        {
            a = a  + 44;
        }

        
    }
}
