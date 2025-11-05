namespace ClassMethod.Practice;

class Program
{
    static void Main(string[] args)
    {
        // // Console.WriteLine("Hello, World!");
        // int[] arr = {  2, 3, 4, 5, };
        // Console.WriteLine(  SumOfArrayElements(arr));
        // var result =AddElementToArray(new int[] { 33, 44 },66);
        // foreach (var item in result)
        // {
        //     Console.WriteLine(item);
        // }
        // Console.WriteLine(Factorial(3));
        int[] numbers = {2,3,4 };
        int [] result=FactorialArray(numbers);
        foreach (int num in result)
        {
            Console.WriteLine(num);
        }
    }

    static int SumOfArrayElements(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
                     sum += num;
                     return sum;
    }

    static string RemoveStringFromString(string word)
    {
        string newWord=string.Empty;
        foreach (char letter in word)
        {
            if(letter!=' ')
                newWord += letter;
                
        }

        return newWord;
    }

    static int[] AddElementToArray(int[] array, int num)
    {
        int[] newArray = new int[array.Length + 1];
        for (int i = 0; i < array.Length; i++)
              newArray[i] = array[i];
        newArray[newArray.Length-1] = num;
        return newArray;
    }

    static int Factorial(int num)
    {
        int result = 1;
        for (int i=1; i<=num; i++)
            result *= i;
            return result;
    }

    static int[] FactorialArray(int[] array)
    {
        for (int i=0; i<array.Length; i++)
              array[i]=Factorial(array[i]);
        return array;
    }
    
    
}