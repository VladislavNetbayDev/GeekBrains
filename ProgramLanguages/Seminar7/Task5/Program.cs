﻿// Задача 3: Задайте двумерный массив. 
// Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2
// Сумма элементов главной диагонали: 1+9+2 = 12

int inputValue(string message)
{
    System.Console.Write($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillArray(int cnt)
{
    int[,] array = new int[cnt, cnt];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
int SummDiagElem(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        sum = sum + matr[i, i];
    }
    return sum;
}

int count = inputValue("Введите количество строк / столбцов: ");

int[,] array = FillArray(count);
PrintArray(array);
Console.WriteLine($"Sum is {SummDiagElem(array)}");