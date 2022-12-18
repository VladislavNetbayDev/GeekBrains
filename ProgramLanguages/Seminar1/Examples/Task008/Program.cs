// Составить программу, которая выводит числа от 0 до 100
// Если число кратно 3, то вместо числа пишет FIZZ
// Если число кратно 5, то вместо числа пишет BUZZ
// Если число кратно и 3 и 5, то вместо числа пишет FIZZBUZZ
// Вариант 1
// int N = 1;
// while (N <= 100)
// {
//     if (N % 3 == 0 && N % 5 == 0)
//     {
//         System.Console.WriteLine("FIZZBUZZ");
//     }
//     else if (N % 5 == 0)
//     {
//         System.Console.WriteLine("BUZZ");
//     }
//     else if (N % 3 == 0)
//     {
//         System.Console.WriteLine("FIZZ");
//     }
//     else System.Console.WriteLine(N);
//     N++;
// }

// Вариант 2
bool Is_BUZZ (int N)
{
    if (N % 5 == 0)
    {
        Console.Write("BUZZ");
        return true;
    }
    return false;
}
bool Is_FIZZ (int N)
{
    if (N % 3 == 0)
    {
        Console.Write("FIZZ");
        return true;
    }
    return false;
}
int N = 1;
while (N <=100)
{
    if (Is_FIZZ(N) | (Is_BUZZ(N)))
    {
        Console.WriteLine();
    }
    else Console.WriteLine(N);
    N++;
}