using System;
// Tekli Kalýtým yalnýzca bir sýnýftan miras alan türetilmiþ sýnýfa denir
class Hayvanlar
{
    public void Yemek ()
    {
        Console.WriteLine("Hayvanlar yemek yer");
    }
}

class Kopekler : Hayvanlar
{
    public void Havlamak ()
    {
        Console.WriteLine("Köpekler havlar");
    }
}

// Çok Düzeyli Kalýtým dededen toruna iliþkiside denebilir

class Memeliler : Hayvanlar
{
    public void Kosmak()
    {
        Console.WriteLine("Memeliler yürür");
    }
}

class Koyunlar : Memeliler 
{
    public void Melemek ()
    {
        Console.WriteLine("Koyunlar meler");
    }
}

// Hiyerarþik Kalýtým üveylik
class Kuslar : Hayvanlar
{
    public void Ucmak()
    {
        Console.WriteLine("Kuþlar uçar");
    }
}

class Serce : Kuslar
{
    public void Kucuk ()
    {
        Console.WriteLine("Serçeler küçüktür");
    }
}

class Penguen : Kuslar
{
    public void Yuzmek ()
    {
        Console.WriteLine("Penguenler yüzer");
    }
}

// Çoklu Kalýtým 2 veya daha fazla temel sýnýftan miras alan türetilmiþ sýnýf genetiklik de denebilir

interface I1
{
    void Method1();
}

interface I2
{
    void Method2();
}

class XYZ: I1, I2
{
    public void Method1()
    {
        Console.WriteLine("Anne Özelliði");
    }
    
    public void Method2()
    {
        Console.WriteLine("Baba Özelliði");
    }
}

// main program

class Program
{
    static void Main(string[] args)
    {
        // Tekli Kalýtým
        Kopekler kopekler1 = new Kopekler();
        kopekler1.Yemek();
        kopekler1.Havlamak();

        // Çok Düzeyli Kalýtým

        Koyunlar koyunlar1 = new Koyunlar();
        koyunlar1.Melemek();
        koyunlar1.Kosmak();
        koyunlar1.Yemek();

        // Hiyerarþik Kalýtým

        Serce serce1 = new Serce();
        Penguen penguen1 = new Penguen();
        serce1.Ucmak();
        serce1.Kucuk();
        penguen1.Yuzmek();
        penguen1.Ucmak();

        XYZ cocuk = new XYZ();
        cocuk.Method1();
        cocuk.Method2();
    }
}




