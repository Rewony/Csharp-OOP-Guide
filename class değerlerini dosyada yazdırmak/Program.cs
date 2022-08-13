using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace class_değerlerini_dosyada_yazdırmak
{
    class Program
    {
        static void Main(string[] args)
        {
            A1 yeni = new A1();
            


        }

        class A1
        {

            public string[] dizi = new string[10];
            
            public A1()
            {
                for(int i = 0; i <= 10; i++)
                {
                    string[i] satırlar = { "öğrenci no:123", "adı:mehmet", "soyadı:yılmaz" }
                   System.I0.File.Writelines(@"c:\deneme\deneme.txt"satırlar);




                }



            }



        }



    }
}
