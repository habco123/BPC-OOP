using cv7;

class Program
{
    public static void Main()
    {
        int[] arr = new int[] { 1, 3, 5, 7, 9};
        Kruh[] kruhArr = new Kruh[] { new Kruh(4), new Kruh(1), new Kruh(2) };
        Obdlznik[] obdlznikArr = new Obdlznik[] { new Obdlznik(2.1, 5), new Obdlznik(5, 9.5), new Obdlznik(1, 2.2) };
        Elipsa[] elipsaArr = new Elipsa[] { new Elipsa(1, 5), new Elipsa(2.2, 1.1), new Elipsa(6.7, 7) };
        Trojuholnik[] trojuholnikArr = new Trojuholnik[] { new Trojuholnik(2, 2, 3), new Trojuholnik(2, 3, 4), new Trojuholnik(3, 4, 5) };
        Stvorec[] stvorecArr = new Stvorec[] { new Stvorec(1), new Stvorec(2), new Stvorec(3) };


        Console.WriteLine("Najvetsi a najmensi Kruh:");
        Console.WriteLine(ArrToString(Extremy.Nejvetsi(kruhArr).ToArray()));
        Console.WriteLine(ArrToString(Extremy.Nejmensi(kruhArr).ToArray()));


        Console.WriteLine("Najvetsi a najmensi Stvorec:");
        Console.WriteLine(ArrToString(Extremy.Nejvetsi(stvorecArr).ToArray()));
        Console.WriteLine(ArrToString(Extremy.Nejmensi(stvorecArr).ToArray()));

        Console.WriteLine("Najvetsi a najmensi obdlznik:");
        Console.WriteLine(ArrToString(Extremy.Nejvetsi(obdlznikArr).ToArray()));
        Console.WriteLine(ArrToString(Extremy.Nejmensi(obdlznikArr).ToArray()));

        Console.WriteLine("Najvetsi a najmensi Elipsa:");
        Console.WriteLine(ArrToString(Extremy.Nejvetsi(elipsaArr).ToArray()));
        Console.WriteLine(ArrToString(Extremy.Nejmensi(elipsaArr).ToArray()));

        Console.WriteLine("Najvetsi a najmensi trjuhonik:");
        Console.WriteLine(ArrToString(Extremy.Nejvetsi(trojuholnikArr).ToArray()));
        Console.WriteLine(ArrToString(Extremy.Nejmensi(trojuholnikArr).ToArray()));

        Console.WriteLine("Filtered values");
        Console.WriteLine(ArrToString(arr.Where(e => e > 4 && e < 8).ToArray()));
        Console.ReadLine();
    }

    public static String ArrToString(Array list)
    {
        String ret = "";

        foreach (var item in list)
        {
            if (ret.Equals(""))
            {
                ret = ret + item.ToString();
            }
            else
            {
                ret = ret + "\n" + item.ToString();
            }
        }

        return ret;
    }
}

