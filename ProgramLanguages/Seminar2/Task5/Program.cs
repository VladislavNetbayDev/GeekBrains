// 2.1. Напишите программу, 
// которая выводит случайное число из отрезка [10, 9999] 
// и показывает наибольшую цифру числа.
// 7812 -> 8 
// 1213-> 3 
// 845 -> 8

// int value = new Random().Next(10, 9999); // Вводим переменную выбора случайного числа в промежутке от 10 до 99
// System.Console.WriteLine(value);
int value = 7812;
int max = 0;
while (value > 0)
{
    int num = value % 10;
    value = value / 10;
    if(max < num)
    {
        max = num;
    }
}
System.Console.WriteLine($"Max = {max}");