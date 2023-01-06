﻿// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.
int[,] ChangePlaceRow(int[,] list)
{
    int i = 0;
    for (int j = 0; j < list.GetLength(1); j++)
    {
        int lastRow = list.GetLength(0) - 1; // Переменной последняя строка присваиваем значение последняя строка -1
        int number = list[0, j];
        list[0, j] = list[lastRow, j];
        list[lastRow, j] = number;
    }
    return list;
}

void PrintArray(int[,] list)
{
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            System.Console.Write($"{list[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] array = 
{
    {1, 2, 3,},
    {4, 5, 6}
};
PrintArray(array);
PrintArray(ChangePlaceRow(array));