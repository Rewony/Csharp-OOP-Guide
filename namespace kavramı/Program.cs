using System;

namespace namespace_kavramı
{
    class Program
    {
        //belirli bir görevi gerçekleştirmek için yazılan kod bütünlüğünne
        //namespace denir
        static void Main(string[] args)
        {
            //namespace kullanarak nesne oluşturdum
            goktug.MyClass nesne = new goktug.MyClass();

            //ekrana yazdırdım

            nesne.Method();
        }

    }
}


namespace goktug
{

    public class MyClass:hasan
    {
        public void Method()
        {
            Console.WriteLine("merhaba");
        }
    }


    interface hasan
    {
        public void hüseyin()
        {
            Console.WriteLine("avengers hüseyin");
        }
    }

}