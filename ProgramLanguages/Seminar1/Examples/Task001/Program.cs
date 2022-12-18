// Задача: Вывести квадрат числа
// Вариант 1.
// Console.WriteLine("start");
// Console.WriteLine("Введите число: ");
// int number = 4;
// int result = number * number;
// Console.WriteLine(result);
// Console.WriteLine("end");
// Вариант 2
Console.Write("Введите число: ");
string inputValue = Console.ReadLine(); 
int value = Convert.ToInt32(inputValue); // Перевод из string в int
int squareValue = value * value;
// Вариант 1
System.Console.WriteLine("Квадрат значения " + value + " равен " + squareValue);
// Вариант 2
System.Console.WriteLine($"Квадрат значения {value} равен {squareValue}");