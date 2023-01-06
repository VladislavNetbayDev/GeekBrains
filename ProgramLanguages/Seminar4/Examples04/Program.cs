// Задача 3: Напишите программу, 
// которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]



void PrintArray(int [] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        System.Console.Write(array[j] + " ");
    }
}
int [] GenerateArray(int Length, int minRange, int maxRange)
{
    int [] array = new int[Length]; 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange);
    }
    return array;
}
int [] arr = GenerateArray(8, 0, 1);
PrintArray(arr);





