using System;


namespace iç_içe_static_classlar
{
    class Program
    {
        static void Main(string[] args)
        {

            insan.age = 12;

        }

        static class insan
        {

           public static string ad;

            public static int age;

            public static string mal_varlığı;
            //oluşturduğum static class özellikleri içerisinde ayrı bir statik class oluşturdum
            //statik classlar kalıtım almazlar
            static class mühendis
            {
                public static string alanı;

                public static int maaşı;
                public static string yabancı_dili;

            }

        }



    }
}
