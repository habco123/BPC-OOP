using System.Runtime.ConstrainedExecution;

class Program
{
    public static void Main()
    {
        string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
        + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
        + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
        + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
        + "posledni veta!";

        StringStatictics str = new StringStatictics(testovaciText);
        Console.WriteLine(testovaciText);
        Console.WriteLine("Pocet slov: {0}", str.WordCount());
        Console.WriteLine("Pocet Riadkov: {0}", str.RowCount());   
        Console.WriteLine("Pocet viet: {0}", str.NumberOfSentences());
        Console.WriteLine("Najvacsie slovo: {0}", str.PrintArrayList(str.LongestWords()));
        Console.WriteLine("Najmensie slovo: {0}", str.PrintArrayList(str.ShortestWords()));
        Console.WriteLine("Najcastejsie slovo: {0}", str.PrintArrayList(str.MostCommonWords()));
        Console.WriteLine("Zoradene: {0}", str.PrintArrayList(str.SortedArray()));
    }
}