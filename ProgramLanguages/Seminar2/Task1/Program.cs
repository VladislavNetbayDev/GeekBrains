﻿// Написать программу, которая принимает на вход трёхзначное число и выдаёт его последнюю цифру
                                        // Первый вариант
// int Promt(string message) // Promt в переводе подсказка. Описываем функцию нахождения числа
// {
//     System.Console.WriteLine($"{message}: "); // Выводит на консоль сообщение, которое будет написано в дальнейшем при вызове метода Promt
//     int answer = Convert.ToInt32(Console.ReadLine()); // Записываем значение в переменную answer путём ввода этого значения в консоль и преобразовывает из string в int
//     return answer; // Записываем найденное значение в функцию и прекращаем её выполнение
// }
// int number = Promt("Введите число: "); // Вызываем функция ввода числа 
// if (number > 99 && number < 1000) // Условие
// {
//     int result = number % 10; // Вычисляем остаток от числа при делении на десять
//     System.Console.WriteLine($" Последняя цифра трехзначного числа {number} равна {result}"); // Выводит на консоль остаток от деления на десять
// }
// else 
// {
//     System.Console.WriteLine("Число не трехзначное"); // Выводит на консоль альтернативный исход
// }

                                                // Второй вариант

int Promt(string message) // Promt в переводе подсказка. Описываем функцию нахождения числа
{
    System.Console.WriteLine($"{message}: "); // Выводит на консоль сообщение, которое будет написано в дальнейшем при вызове метода Promt
    int answer = Convert.ToInt32(Console.ReadLine()); // Записываем значение в переменную answer путём ввода этого значения в консоль и преобразовывает из string в int
    return answer; // Записываем найденное значение в функцию и прекращаем её выполнение
}

bool ValidateNumber(int number) // Описываем метод проверки условия трехзначности числа
{
    if (number > 99 && number < 1000)
    {
        return true;
    }
    System.Console.WriteLine("Число не трехзначное"); // Выводит на консоль альтернативный исход
    return false;
}

int number = Promt("Введите число: "); // Вызываем функция ввода числа 
if (ValidateNumber(number)) // Условие
{
    int result = number % 10; // Вычисляем остаток от числа при делении на десять
    System.Console.WriteLine($" Последняя цифра трехзначного числа {number} равна {result}"); // Выводит на консоль остаток от деления на десять
}

