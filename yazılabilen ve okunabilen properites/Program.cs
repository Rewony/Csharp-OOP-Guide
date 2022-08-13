using System;

namespace yazılabilen_ve_okunabilen_properites
{
    class Program
    {
        static void Main(string[] args)
        {
            A yeni = new A();
            //değer atadım
            yeni.Değer = 5;
            //atadığım değerleri yazdırdım
            Console.WriteLine(yeni.Değer);

        }

        class A
        {
            int değer;
            //int olarak private olan bir değer atadım
            //bu değere değer atamak properites kullandım
            public int Değer { get {
                    return değer;
                    //get methodu değer döndürmemi sağladı
                } 
                set {
                    //set methodu değer girmemi sağladı
                    değer = value;

                } }


        }


    }
}
