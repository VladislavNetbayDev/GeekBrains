// Написать программу, которая на вход принимает число, а на выходе показывает обратное ему
System.Console.WriteLine("Введите число: ");
string inputValue = Console.ReadLine();
double value = Convert.ToDouble(inputValue);

double N = 1/value;
System.Console.Write($"Обратное число {value} равно {N}");
