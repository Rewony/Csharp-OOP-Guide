using System;

namespace delege_ile_kontorller_yordamı_belirlemek
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        class uzay
        {
            public int b = 0;
            //Prosedür tanımlandı
            public void seçim(object kendisi, EventArgs e)
            {
                b++;
            }
            public void yazdir()
            {
                Console.WriteLine(b);
            }
            //Delege tanımlandı
            public delegate void yordam(object kendi, EventArgs e);
        }
    }



}

