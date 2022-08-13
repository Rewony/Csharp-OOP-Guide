using System;

namespace interfaces
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // B classına bağlı değişken oluşturdum
            B demo = new B();
            //örnek yazdırdım
            demo.değerler();


        }
        //interfaceden classlara kalıtım verilebilir
        //cllaslar bir class tan türeyebilirken bir den fazla interfaceden kalıtım alabilir
        //interfacelerin içine kod yazamayız
        interface A
        {
            void değerler();
        }
        //interfacem B ye kalıtım verdi
        class B : A
        {

            public void değerler()
            {
                Console.WriteLine("interface kullandın");
            }


        }






    }
}
