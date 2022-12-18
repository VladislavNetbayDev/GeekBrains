// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
System.Console.WriteLine("Введите число N1 ");
string inputValue1 = Console.ReadLine();
int value1 = Convert.ToInt32(inputValue1);

System.Console.WriteLine("Введите число N2 ");
string inputValue2 = Console.ReadLine();
int value2 = Convert.ToInt32(inputValue2);
int max = value1;
if (value2 > value1)
{
    max = value2;
}
System.Console.WriteLine($"Наибольшее число {max}");

git remote add origin https://github.com/VladislavNetbayDev/HomeWork.git