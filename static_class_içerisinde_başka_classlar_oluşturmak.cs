using System;

public static class sınıf1
{
    //static clasın üyeleri static olur
    //static üyelerden new komutu ile nesne oluşturulamaz
    public static string meyve_adı = "karpuz";
    public static int meyve_adedi = 2;
    public static int mevyefiyat = 10;
    //bütün herşeyi static girdim
    public static string yaz_adı ()
        return meyve_adı;

    public static int yaz_adedi()
        return meyve_adedi;

        public static int yaz_fiyat()
        return mevyefiyat;
        //statik class oluşturduktan sonra başka içerisinde başka classlarda oluşturabiliriz ve bunların static olması gerekmez
        public class masa
    {
        //static olmayan değerler girdim
        public int ayaksayısı;

        public string yapı_malzemesi;

        public void değerata() { ayaksayısı = 4; yapı_malzemesi = "ahşap"; }

        public void yazdır() { Console.WriteLine("ayaksayısı",ayaksayısı);
            Console.WriteLine("yapı malzemesi",yapı_malzemesi);
        }



    }






}
