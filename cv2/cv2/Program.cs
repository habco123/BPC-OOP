
using System.Security.Cryptography;

class Program
{
    public static void Main()
    {
        TestComplex.Test(new Complex(2.1, 3.8) + new Complex(1, 4), new Complex(3.1, 7.8), "test +");
        TestComplex.Test(new Complex(2.1, 3.8) - new Complex(1, 4), new Complex(1.1, -0.2), "test -");
        TestComplex.Test(new Complex(2.1, 3.8) * new Complex(1, 4), new Complex(-13.1, 12.2), "test *");
        TestComplex.Test(new Complex(2.1, 3.8) / new Complex(1, 4), new Complex(1.01764, -0.2058), "test /");
        TestComplex.Test(-new Complex(2.1, 3.8), new Complex(-2.1, -3.8), "test u-");
        TestComplex.Test(new Complex(2.1, 3.8).zdruzene(), new Complex(2.1, -3.8), "test zdruzene");


        Complex c = new Complex(1.2, 3.4);
        Complex c2 = new Complex(1.2, 3.4);

        Console.WriteLine("je {0} == {1}: {2}", c, c2, c == c2);
        Console.WriteLine("je {0} != {1}: {2}", c, c2, c != c2);
        Console.WriteLine("modul pre {0} je {1}", c, c.Modul());
        Console.WriteLine("argmument pre {0} je {1}", c, c.Argument());

    }
}