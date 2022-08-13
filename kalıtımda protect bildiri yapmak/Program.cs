using System;

namespace kalıtımda_protect_bildiri_yapmak
{
    class Program
    {
        static void Main(string[] args)
        {
            // protected  değere, bulunduğu class  ve ondan türetilen diğer sınıflar içinden erişilebilir
            //dışarıdan erişilemez

            hüseyin yeni = new hüseyin();
            hüseyin.a = 40;
            //görüldüğü gibi dışarıdan değer giremiyoz çünkü protected bir değişken


        }

        class mehmet
        {
           
  
            protected int a;
            protected string b;
        }
        

        class hüseyin : mehmet
        {
            public int gh;
            public int c;
            public void yazar(int a,int b)
            {
                gh = a;
                c = b;
            }
            
        }
    }
}
