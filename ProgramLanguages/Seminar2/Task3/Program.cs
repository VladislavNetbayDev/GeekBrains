﻿// Напишите программу, которая принимает на вход два числа и выводит является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления

int Promt(string message) // Promt в переводе подсказка. Описываем функцию нахождения числа
{
    System.Console.WriteLine($"{message}: "); // Выводит на консоль сообщение, которое будет написано в дальнейшем при вызове метода Promt
    int value = Convert.ToInt32(Console.ReadLine()); // Записываем значение в переменную answer путём ввода этого значения в консоль и преобразовывает из string в int
    return value; // Записываем найденное значение в функцию и прекращаем её выполнение
}

int value1 = Promt($"Введите первое число: ");
int value2 = Promt($"Введите второе число: ");

int div = value1 % value2;
if (div > 0)
{
    System.Console.WriteLine($"Число {value1} не кратно числу {value2}");
    System.Console.WriteLine($"Остаток от деления числа равен {div}");
}
else 
{
    System.Console.WriteLine($"Число {value1} кратно {value2}");
}