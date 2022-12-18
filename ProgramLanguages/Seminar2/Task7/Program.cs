// 4.1. Напишите программу, 
// которая генерирует несколько случайных чисел, 
// и в цикле проверяет, кратны ли эти числа 
// предварительно введенному числу, 
// при кратности - цикл прерывается.
// Введенное число 2
// 13 -> нет 
// 15 -> нет 
// 12 -> да
int inputValue(string message)
{
    System.Console.Write($"{message}");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int divider = inputValue("add divider: ");

// int Random()
// {
//     int number = new Random().Next(0, 10);
//     return number;
// }
while (true) // Выполняем всегда
 {
    int value = new Random().Next(0, 10);
    System.Console.WriteLine(value);
    if (value % divider == 0)
    {
        System.Console.WriteLine($"divider = {value}");
        break;
    }
 }

