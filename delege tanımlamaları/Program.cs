using System;

namespace delege_tanımlamaları
{
    class Program
    {
        static void Main(string[] args)
        {


        }
        //delegeler metod pointerleridir metodun adresini tutarlar
        class hasan
        {
            public  int a;
            //Delege tanımlandı
            public delegate void C(int deger);
            //delegeye ait metod tanımlandı
            public void Metod1(hasan.C melt)
            {
                melt(a);
            }
        }
    }
}