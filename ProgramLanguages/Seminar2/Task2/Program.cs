// Написать программу, которая выводит случайное число и показывает наибольшую цифру данного числа
int value1 = new Random().Next(10, 99); // Вводим переменную выбора случайного числа в промежутке от 10 до 99
System.Console.WriteLine(value1);
int edinitsi = value1 % 10;
int desyatki = value1 / 10;

if (edinitsi > desyatki)
{
    System.Console.WriteLine($"наибольшая цифра числа {edinitsi}");
}
else 
{
    System.Console.WriteLine($"наибольшая цифра числа {desyatki}");
}
