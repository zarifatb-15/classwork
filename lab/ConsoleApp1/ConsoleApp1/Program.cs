//TASK1
// Console.Write("Cixarilan mebleqi daxil edin");
// int amount = Convert.ToInt32(Console.ReadLine());
// if (amount <= 0)
// {
//     Console.WriteLine("Menfi ve ya 0 mebleg qebul olunmur.");
// }
// else if (amount % 5 != 0)
// {
//     Console.WriteLine("En kicik eskinas 5 manatdir.");
// }
// else
// {
//     int note100, note50, note20, note10, note5;
//     note100 = amount / 100;
//     amount = amount % 100;
//     
//     note50 = amount / 50;
//     amount = amount % 50;
//     
//     note20 = amount / 20;
//     amount = amount % 20;
//     
//     note10 = amount / 10;
//     amount = amount % 10;
//     
//     note5 = amount / 5;
//     amount = amount % 5;
//
//     Console.WriteLine(note100);
//     Console.WriteLine(note50);
//     Console.WriteLine(note20);
//     Console.WriteLine(note10);
//     Console.WriteLine(note5);
// }


//TASK2
// decimal amount =10;
// decimal usd = amount *1.7m;
// decimal eur = amount * 0.51m;
// decimal tr= amount *25m;
// Console.WriteLine($"{amount} AZN = {usd} USD");
// Console.WriteLine($"{amount} AZN = {eur} EUR");
// Console.WriteLine($"{amount} AZN = {tr} TRY");



//TASK3
// int age= Convert.ToInt32(Console.ReadLine());
// var price = 0.6;
// bool isStu=true;
// if(age<=6) Console.WriteLine("gedis pulsuzdur");
// if (isStu || (age > 6 && age < 10))
// {
//     price = price * 0.5;
//     Console.WriteLine($"total price: {price}");
// }
//
// if (age > 60)
// {
//     price = price * 0.7;
//     Console.WriteLine($"total price: {price}");
// }



//TASK4

// int entr = 9;
// int exit = 12;
// int total=2*(exit - entr);
// Console.WriteLine(total);


//TASK5

// string input ="hi hi hello hi";
// int hicount= 0;
// int hellocount=0;
// string[] words= input.Split(' ');
// for (int i = 0; i < words.Length; i++)
// {
//     if (words[i] == "hi") continue;
//     int count = 1;
//     for (int j = i + 1; j < words.Length; j++)
//     {
//         if (words[i] == " ")
//         {
//             count++;
//             words[j] = " ";
//         }
//     }
//
//     Console.WriteLine($"{words[i]} = {count}");
// }