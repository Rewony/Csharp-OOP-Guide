using System;

namespace class_içerisinde_parametreli__fonksiyon_tanımlamak
{
    class Program
    {
        //bir fonksiyonun içerisinde parantezler içerisinde değerler vererek onu parametreli hale getiririm
        static void Main(string[] args)
        {

            otsular j = new otsular(12, 1);


        }

        class otsular
        {   
            //değişkenler oluşturdum
            private int v1;
            private int v2;
            //parametreli fonksiyon oluşturdum
            public otsular(int v1, int v2)
            {
                //this pointerini kullanarak değer atamsı yaptım
                this.v1 = v1;
                this.v2 = v2;
            }

            
           


        }


    }
}
