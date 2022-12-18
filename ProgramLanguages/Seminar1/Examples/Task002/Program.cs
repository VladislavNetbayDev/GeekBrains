Console.Write("Введите первое число: ");
string inputValue1 = Console.ReadLine();
int value1 = Convert.ToInt32(inputValue1);

Console.Write("Введите второе число ");
string inputValue2 = Console.ReadLine();
int value2 = Convert.ToInt32(inputValue2);

int squareValue = value1 * value1;
if (squareValue == value2)
{
    Console.Write("yes");
}
else 
{
    Console.Write("NO");
}
// Console.Write("Введите число: ");
// string inputValue = Console.ReadLine(); 
// int value = Convert.ToInt32(inputValue); // Перевод из string в int
// int squareValue = value * value;
// // Вариант 1
// System.Console.WriteLine("Квадрат значения " + value + " равен " + squareValue);
// // Вариант 2
// System.Console.WriteLine($"Квадрат значения {value} равен {squareValue}");