// Задача 2: Напишите программу, 
// которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа. 
// Не использовать строки для расчета

// 456 -> 46
// 782 -> 72
// 918 -> 98

int value = new Random().Next (100, 999);
int a = value / 10 / 10;
int b = value % 10;

System.Console.WriteLine(value);
System.Console.WriteLine($"{a}{b}");