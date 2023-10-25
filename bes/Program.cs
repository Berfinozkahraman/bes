using System;
// Tekli Kal�t�m yaln�zca bir s�n�ftan miras alan t�retilmi� s�n�fa denir
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
        Console.WriteLine("K�pekler havlar");
    }
}

// �ok D�zeyli Kal�t�m dededen toruna ili�kiside denebilir

class Memeliler : Hayvanlar
{
    public void Kosmak()
    {
        Console.WriteLine("Memeliler y�r�r");
    }
}

class Koyunlar : Memeliler 
{
    public void Melemek ()
    {
        Console.WriteLine("Koyunlar meler");
    }
}

// Hiyerar�ik Kal�t�m �veylik
class Kuslar : Hayvanlar
{
    public void Ucmak()
    {
        Console.WriteLine("Ku�lar u�ar");
    }
}

class Serce : Kuslar
{
    public void Kucuk ()
    {
        Console.WriteLine("Ser�eler k���kt�r");
    }
}

class Penguen : Kuslar
{
    public void Yuzmek ()
    {
        Console.WriteLine("Penguenler y�zer");
    }
}

// �oklu Kal�t�m 2 veya daha fazla temel s�n�ftan miras alan t�retilmi� s�n�f genetiklik de denebilir

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
        Console.WriteLine("Anne �zelli�i");
    }
    
    public void Method2()
    {
        Console.WriteLine("Baba �zelli�i");
    }
}

// main program

class Program
{
    static void Main(string[] args)
    {
        // Tekli Kal�t�m
        Kopekler kopekler1 = new Kopekler();
        kopekler1.Yemek();
        kopekler1.Havlamak();

        // �ok D�zeyli Kal�t�m

        Koyunlar koyunlar1 = new Koyunlar();
        koyunlar1.Melemek();
        koyunlar1.Kosmak();
        koyunlar1.Yemek();

        // Hiyerar�ik Kal�t�m

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




