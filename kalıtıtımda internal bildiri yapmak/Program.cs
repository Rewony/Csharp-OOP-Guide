using System;

namespace kalıtıtımda_internal_bildiri_yapmak
{
    class Program
    {
        static void Main(string[] args)
        {
            //değişkeni internal oalrak tanımlandığı için sadece  uygulama üzerinden erişilebilir

            g yeni = new g();
            yeni.a = 5;
            //kalıtım aldığım için f in internal değeri g nin bir parçası oldu yanı g üzerinden f internal değişebilir değer atamsı yapılabilir
        }

        class f
        {
           
            internal int a;
            public int b;
        }
        //g classı değer f ten kalıtım alır
        class g : f
        {
            public int gh;
            public int vg;

            public void metod(int s,int h)
            {
                gh = s;
                vg = h;
            }
        }
    }
}
