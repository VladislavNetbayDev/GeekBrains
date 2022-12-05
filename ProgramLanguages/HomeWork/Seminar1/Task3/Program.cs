// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
System.Console.WriteLine("Введите число: ");
string N = Console.ReadLine();
int A = Convert.ToInt32(N);

if (A % 2 == 0)
{
    System.Console.WriteLine("Является");
}
else 
{
    System.Console.WriteLine("Не является");
}