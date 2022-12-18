// Написать программу, которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23
// 14 нет
// 46 нет
// 161 да
 int Promt(string message)
 {
    System.Console.WriteLine($"{message}");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
 }
int number = Promt("add number");
int delitel1 = Promt("add delitel1: ");
int delitel2 = Promt("add delitel2: ");

if (number % delitel1 == 0 & number % delitel2 == 0)
{
    System.Console.WriteLine($"number {number} кратно 7 и 23");
}
else 
{
    System.Console.WriteLine($"number {number} not a multiple 7 and 23");
}