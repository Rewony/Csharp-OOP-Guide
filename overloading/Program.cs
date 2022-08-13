using System;

namespace overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //bu fonksiyonda yaz isimle fonk string ve int tipindeki değişkenleri parametre aldırttırdım
            //aynı isimden fonk oluşturup farkılı parametreler ile kullanmak overloading tir
            //bu fonksiyonda float ve short ve int tipindeki değerleri parametre olarak aldırttırdım 3 farklı değer verip overloading yaptım
            a yeni = new a();
            // 3 parametreli fonk
            yeni.yaz(23, 2, 132);
            // 2 parametreli fonk
            yeni.yaz("ahmet", 2);

        }

        class a
        {
            public void yaz(string a, int b)
            {

                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            //bu fonksiyonda yaz isimle fonk string ve int tipindeki değişkenleri parametre aldırttırdım

            //bu fonksiyonda float ve short ve int tipindeki değerleri parametre olarak aldırttırdım 3 farklı değer verip overloading yaptım
            public void yaz(float a, short b, int f)
            {
                Console.WriteLine(a);

                Console.WriteLine(b);

                Console.WriteLine(f);
            }
        }
    }
}
