// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;


//int b = 10;
//Console.WriteLine(b.IsEven());
//int a = 10;
//Console.WriteLine(a.IsOdd());


public static class ExtentionMethods
{


    
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
}