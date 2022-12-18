// Задача 1: Напишите программу, 
// которая принимает на вход число (А) и 
// выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int inputValue(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int SumForNumbers(int number)
{
    int sum = 0;
   
    for ( int i = 1; i <= number; i++)
    {
        sum+=i;
    }
    return sum;
}
int SumGaussNumbers(int number)
{
    return(1+number) * number/2;
}
int number = inputValue("Введите число: ");
int result = SumForNumbers(number);
System.Console.WriteLine($" сумма чисел от 1 до {number} равна {result}");
int result2 = SumGaussNumbers(number);
System.Console.WriteLine($" сумма чисел от 1 до {number} равна {result2}");