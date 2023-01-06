// Задача 3: Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 
// Не использовать строки

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int InputValue(string message)
{
    System.Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}
int value = InputValue("Введите число: ");
if (value > 99 && value < 1000)
{
    int result = value % 10;
    System.Console.WriteLine($"Третья цифра заданного числа: {result}");
}
else System.Console.WriteLine("Третьей цифры нет");