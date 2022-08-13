using System;

namespace birden_fazla_consturction
{
    class Program
    {
        //yapıcı fonksiyon class oluşturduktan sonra arka planda otomatik olarak çalıştırılır
        static void Main(string[] args)
        {

            insan player = new insan();

            insan player1 = new insan(12,"mehmet");

            //parametreli fonksiyon yazarak birden fazla yapıcı fonksiyon oluşturabiliriz
            
            


        }

        class insan
        {
            public int yas;

            public string isim;
            //1. yapıcı fonksiyon(parametresiz)
          public insan()
            {
                yas = 12;
                isim = "zeynep";

            }

            //2. yapıcı fonksiyon (parametreli)
            public insan(int _yas,string _isim)
            {

                yas = _yas;
                isim = _isim;

            }
            

        }



    }
}
