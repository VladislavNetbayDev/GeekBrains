﻿// Задача 1: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int[] CreateArray(int length, int minRange, int maxRange)
{
    int [] numbers = new int[length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(minRange, maxRange+1);  
    }
    return numbers; 
}
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int SumSign(int [] array, bool isPositive = true)
{
    int sum = 0;
    int sign = 1;
    if (!isPositive)
    {
        sign = -1;
    }
    foreach (int item in array) // item - не индекс, это значение элемента массива
    {
        if (item *sign > 0)
        {
        sum += item;
        }
    }
    return sum;
}

int SumPositive(int [] array)
{
    int sum = 0;
    
    foreach (int item in array) // item - не индекс, это значение элемента массива
    {
        if (item > 0)
        {
        sum += item;
        }
    }
    return sum;
}

int length = 12;
int minValue = -9;
int maxValue = 9;

int [] arr = CreateArray(length, minValue, maxValue);
PrintArray(arr);

int sumPlus = SumSign(arr);
int sumMinus = SumSign(arr, false);
System.Console.WriteLine($"Сумма положительных чисел = {sumPlus}, а отрицательных =  {sumMinus}");
