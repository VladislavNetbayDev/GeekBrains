int inputValue(string message)
{
    System.Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}
int [,] FillCreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = (i + 1) * (j + 1);
        }
    }
    return array;
}
void PrintArrayTwo(int[,] matr)
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
int m = inputValue("input count string: ");
int n = inputValue("Input count stolbcov: ");
PrintArrayTwo(FillCreateArray(m, n));
остановилсчя на 48:50