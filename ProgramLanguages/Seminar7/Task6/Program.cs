// Задача 4: Задайте двумерный массив. 
// Введите элемент, и найдите первое его вхождение, 
// выведите позиции по горизонтали и вертикали, 
// или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

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
(int?, int?) SearchElement(int[,] matr,int SearchEl ) // (int, int) - Возвращаем два значения
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (SearchEl == matr[i, j])
            {
                return (i, j);
            }

        }
    }
    return (null, null);
}



int rows = inputValue("Введите количество строк: ");
int coloums = inputValue("Введите количество столбцов: ");
int [,] array = FillCreateArray(rows, coloums);
PrintArray(array);
int SearchEl = inputValue("Input element: ");
(int? foundedRow, int? foundedColoum) = SearchElement(array, SearchEl);
if (foundedRow == null)
{
    System.Console.WriteLine("Element is not founded");
}
else System.Console.WriteLine($"Row is {foundedRow},  coloum is {foundedColoum}");