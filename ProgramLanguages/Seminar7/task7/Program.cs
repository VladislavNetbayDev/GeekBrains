// Задача 5: Задайте двумерный массив. 
// Найдите максимальный элемент массива и 
// среднее арифметическое всех элементов массива.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Максимальный элемент массива 9
// Среднее арифметическое 4.25


int inputValue(string message)
{
    System.Console.Write($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillCreateArray(int m, int n)
{
    int[,] array = new int[m, n];
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

int Maximus(int[,] matr)
{
    int max = matr [0, 0];
    foreach (int item in matr)
    {
        if(max < item)
        {
            max = item;
        }
    }
    return max;
}

double Average(int[,] matr)
{
    double sum = 0;
    foreach (int item in matr)
    {
        sum += item;
    }
    return sum/matr.Length;
}

int rows = inputValue("Input number of rows: ");
int coloums = inputValue("Input number of coloums: ");
int[,] array = FillCreateArray(rows, coloums);
PrintArray(array);
System.Console.WriteLine($"Maximum element is {Maximus(array)}");
System.Console.WriteLine($"Average element is {Average(array)}");