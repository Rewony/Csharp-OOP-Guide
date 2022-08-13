using System;

namespace hatırlama
{
    class Program
    {
        static void Main(string[] args)
        {
            matematik a = new matematik(topla);
            int sonuc = matematik(10, 5);

        }

        public delegate int matematik(int z, int y);
        int topla(int a,int b) 
        {

            return a + b;
        }

        int carp(int a,int b) 
        {

            return a * b;

        }



    }

  
}
