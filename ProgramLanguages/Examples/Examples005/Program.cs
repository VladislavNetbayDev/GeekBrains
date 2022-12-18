//  5. Написать программу вычисления значения функции y = f(x) Подсказка f(x) = x^2 + 1
System.Console.WriteLine("Введите число x");
string inputValue = Console.ReadLine();
int x = Convert.ToInt32(inputValue);
int y = x * x + 1;
System.Console.WriteLine($"Функция f(x) = {y}");

