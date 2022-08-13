using System;

namespace class_içerisinde_birden_fazla_parametreli_fonksiyon_tanımlamak
{
    class Program
    {
        static void Main(string[] args)
        {
            //örnek oluşturdum
            araba bent = new araba();
            


        }


        class araba
        {
            public string marka;
            public int para;
            public int model;
        }
        // 1. parametreli fonk oluşturdum
        public int paragir(int f)
        {
            return f;
        }
        //2. parametreli fonk oluşturdum
        public string marka(string g)
        {
            return g;
        }

        //3. parametreli fonk oluşturdum

        public int model(int g)
        {
            return g;
        }



    }


}
