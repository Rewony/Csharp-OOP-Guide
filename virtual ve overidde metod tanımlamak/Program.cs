using System;

namespace virtual_ve_overidde_metod_tanımlamak
{
    class Program
    {
        //kalıtımda kalıtım alan sınıf ile ana sınıf aynı isimli fonk sahipse kalıtım alan sınıfın kullanılarak temel sınıfın devre dışı klamsına 
        //overridde denir virtual fonk ile yapılır
        static void Main(string[] args)
        {
            aslan yeni = new aslan();
            yeni.sesver();
            

        }

        class kedi
        {
            // 2 farklı sesver ver metodu oluşturarak overloading yaptım
            //burada kedi yi virtual alarak kalıtım alan sınfın sesver fonk çalışmasını sağladım
            public virtual void sesver()
            {
                Console.WriteLine("miyav");
            }
        }

        class aslan :kedi
        {//aslan kedieddn kalıtım aldı
            //burada aslan ses ver fonksiyosu override yaparak kedideki sesver fonksiyonu ezer
            public void  sesver()
            {
                Console.WriteLine("hırağğğğğ");
            }


        }


    }
}
