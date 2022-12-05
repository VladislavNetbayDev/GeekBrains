// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите число N1: ");
string inputValue1 = Console.ReadLine();
int N1 = Convert.ToInt32(inputValue1);

System.Console.WriteLine("Введите число N2: ");
string inputValue2 = Console.ReadLine();
int N2 = Convert.ToInt32(inputValue2);

System.Console.WriteLine("Введите число N3: ");
string inputValue3 = Console.ReadLine();
int N3 = Convert.ToInt32(inputValue3);

int max = N1;
if (N2 > max) 
{
    max = N2;
}
if (N3 > max) 
{
    max = N3;
}
System.Console.WriteLine($"Максимальное из трёх чисел = {max}");
