// Задача 3: Напишите программу, 
// которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int [] GenerateArray(int Length, int MinRange, int MaxRange)
{
    int [] array = new int[Length]; 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(MinRange, MaxRange+1);
    }
    return array;
}
void PrintArray(int [] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        System.Console.Write(array[j] + " ");
    }
}
int InputValue(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Range = InputValue("Введите длину массива: ");

int MinValue = InputValue("Введите минимальное значение: ");

int MaxValue = InputValue("Введите максимальное значение: ");

int [] arr = GenerateArray(Range, MinValue, MaxValue);

PrintArray(arr);