using System.Formats.Asn1;
using System.Security.Cryptography;
using cv5;

class Program
{
    public static void Main()
    {

        Osobni a1 = new Osobni(Auto.TypPaliva.benzin, 50, 5);
        Nakladni n1 = new Nakladni(Auto.TypPaliva.nafta, 500, 50000);

        Console.WriteLine(a1);
        a1.Natankuj(Auto.TypPaliva.benzin, 40);
        a1.setPredvolba(1, 103.5);
        a1.setPreset(1);
        a1.setPocetOsob(4);
        Console.WriteLine(a1);

        Console.WriteLine(n1);
        n1.Natankuj(Auto.TypPaliva.nafta, 477);
        n1.setPredvolba(1, 77.5);
        n1.setPreset(1);
        n1.setNaklad(15987);
        Console.WriteLine(n1);
    }
}