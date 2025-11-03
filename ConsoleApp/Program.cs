// See https://aka.ms/new-console-template for more information

using System.Reflection;
using System.Threading.Channels;


//int b = 10;
//Console.WriteLine(b.IsEven());
//int a = 10;
//Console.WriteLine(a.IsOdd());
// string txt = "baBAYevA";
// Console.WriteLine(txt.ToCapitalize());
// string word = "babayeva";
// int[] result = word.GetValueIndexes('a');
// Console.WriteLine($"'{word}' sozunde 'a' herfi bu indexlerdedir:");
// Console.WriteLine(string.Join(", ", result));


public static class ExtentionMethods
{


    //TASK1
    public static bool IsOdd (this int number)
    {
        return number % 2 != 0;
    }
    
   
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }

    public static bool IsContainsDigit(this string text)
    {
        foreach (var item in text)
        {
            if (item >= 0 && item <= 9)
            {
                return true;               
            }
        }
        return false;
    }

    public static string ToCapitalize(this string text)
    {
        if(string.IsNullOrEmpty(text))
            return text;
        char first=char.ToUpper(text[0]);
        string rest = text.Substring(1).ToLower();
        return first + rest;
    }

    public static int[] GetValueIndexes(this string text, char c)
    {
        List<int> index = new List<int>();
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == c)
                index.Add(i);
        }

        return index.ToArray();
    }

    public static string GetFirstSentence(this string sentence)
    {
        
    }
    
    
}