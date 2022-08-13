using System;

namespace indexer_oluşturmak
{
    class Program
    {
        static void Main(string[] args)
        {
            //indexerlar properiteslerin dizi için uygulanan hali diyebiliriz
            efsane_milan_kadrosu kadrosay = new efsane_milan_kadrosu();
            //değer girdim
            kadrosay[0] = "Dida";
            kadrosay[1] = "Cafu";
            kadrosay[2] = "stam";
            kadrosay[3] = "nesta";
            // değer yazdırdım
            Console.WriteLine(kadrosay[2]);

        }
       



        class efsane_milan_kadrosu
        {
            //a takım diye bir dizi oluşturdum
            string[] a_takım = new string[11];
            //burada indexer oluşturdum parametre olarak int deger verdim ki
           public string this[int a]
            {//değer döndürmek için get metodu
                get
                {
                    return a_takım[a];
                }
                // değer girmek için
                set
                {

                    a_takım[a] = value;
                }

            } 


        }


    }
}
