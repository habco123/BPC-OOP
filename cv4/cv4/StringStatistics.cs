
using System.Collections;

using System.Text;


public class StringStatictics
{
    private string text;

    public StringStatictics(string text)
    {
        this.text = text;  
    }

    public int WordCount()
    {
        char[] delimiterChars = { ' ', '\n' };
        int words = text.Split(delimiterChars).Length;
        return words;
    }

    public int RowCount()
    {
        int count = text.Split('\n').Length;
        return count;
    }

    public int NumberOfSentences()
    {
        char[] delimiterChars = { '.', '?', '!' };
        string Text = text.Replace("\n", " ").Replace(" ", "");
        string[] row = Text.Split(delimiterChars);
        int counter = 0;

        for (int i = 0; i < row.Length - 2; i++)
        {
            if (i == 0 && Char.IsUpper(row[i][0]))
            {
                counter++;
            }
            if (Char.IsUpper(row[i + 1][0]))
            {
                counter++;
            }
        }
        return counter;
    }

    public ArrayList LongestWords()
    {
        ArrayList longestWords = new ArrayList();
        string Text = text.Replace("\n", " ").Replace("!", "").Replace("?", "").Replace(",",  "").Replace(".", "").Replace("(", "").Replace(")", "");
        string[] words = Text.Split(' ');
        int biggestLenght = 0;

        foreach (var word in words)
        {
            if (word.Length > biggestLenght)
            {
                biggestLenght = word.Length;
                longestWords.Clear();
                longestWords.Add(word);
            }
            else if (word.Length == biggestLenght)
            {
                longestWords.Add(word);
            }
        }

        return longestWords;
    }
    public ArrayList ShortestWords()
    {
        ArrayList longestWords = new ArrayList();
        string Text = text.Replace("\n", " ").Replace("!", "").Replace("?", "").Replace(",", "").Replace(".", "").Replace("(", "").Replace(")", "");
        string[] words = Text.Split(' ');
        int shortestLength = int.MaxValue;

        foreach (var word in words)
        {
            if (word.Length < shortestLength)
            {
                shortestLength = word.Length;
                longestWords.Clear();
                longestWords.Add(word);
            }
            else if (word.Length == shortestLength)
            {
                longestWords.Add(word);
            }
        }

        return longestWords;
    }


    public StringBuilder PrintArrayList(ArrayList arrlist)
    {
        StringBuilder text = new StringBuilder();
        if (arrlist.Count == 1)
        {
            text.Append(arrlist[0]);
        }
        else
        {
            foreach (var item in arrlist)
            {
                text.Append(item).Append(", ");
            }
        }
        return text;
    }


    public ArrayList MostCommonWords()
    {
        var dict = new Dictionary<string, int>();
        ArrayList commonWords = new ArrayList();
        string Text = text.Replace("\n", " ").Replace("!", "").Replace("?", "").Replace(",", "").Replace(".", "").Replace("(", "").Replace(")", "");
        string[] words = Text.Split(' ');
        int ocurencies = 0;

        foreach (var item in words)
        {
            if (dict.ContainsKey(item))
            {
                dict[item]++;
            }
            else
            {
                dict.Add(item, 1);
            }
        }

        foreach (var key in dict)
        {
            if (key.Value > ocurencies)
            {
                ocurencies = key.Value;
                commonWords.Clear();
                commonWords.Add(key.Key);
            }
            else if (key.Value == ocurencies)
            {
                commonWords.Add(key.Key);
            }
        }

        return commonWords;
    }


    public ArrayList SortedArray()
    {
        ArrayList wordList = new ArrayList();
        string Text = text.Replace("\n", " ").Replace("!", "").Replace("?", "").Replace(",", "").Replace(".", "").Replace("(", "").Replace(")", "");
        string[] words = Text.Split(' ');
        foreach (var item in words)
        {
            wordList.Add(item);
        }
        wordList.Sort();
        return wordList;
    }


}
