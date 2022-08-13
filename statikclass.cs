using System;

public static class Class1
{
    //statik class özelliği bütün üyelerinin statik olmasıdır 
    //bende bütün üyeleri statik yaptım
    public static int sayı1 = 10;
    public static int sayı2 = 25;
    public static int sayı3 = 22;
    public static int sayı4 = 11;
    //değer döndürmek için fonk oluşturdum
    public static int aritmatik_ortalama_hesapla()
    {

        return sayı1 + sayı2 + sayı3 + sayı4 / 4;

    }
    

}
