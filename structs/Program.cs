using System;

namespace structs
{
    class Program
    {
        //struct veri ve fonksiyon içeren yapılardır sınıflara benzerler 
        //sınıflardan farkı struct yapısı değer tiplidir heapte yer tutmaz
        static void Main(string[] args)
        {

            buzdolabı A;
            //burada değerler atadım
            A.fiyat = 15000;
            A.hacim = 1200;
            A.marka = "arçelik";

            Console.WriteLine(A.marka);

        }
    struct buzdolabı
    {
            //structum burada oluşturdum
        public string marka;
        public int hacim;
        public int fiyat;


    }


}
}
