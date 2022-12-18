// string[,] table = new string [2,3]; string - тип данных, запятая - указание 2 размерностей строк и столбцов, table - наименование массива
// int[,] matrix = new int[5,8]; matrix - прямоугольная таблица чисел. 5 - строки, 8 - столбцы
// string [,] table = new string[2,5];
// table[index "строки", index "столбца"]

// table [1, 2] = "слово"; // table - обращение к нужному элементу
// for (int rows = 0; rows < 2; rows++) // rows - строки
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         System.Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }



void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // 0 - строки( обращается к цифре 3)
    {
        for (int j = 0; j < matr.GetLength(1); j++) // 1 - столбцы (4)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
    System.Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // 0 - строки( обращается к цифре 3)
    {
        for (int j = 0; j < matr.GetLength(1); j++) // 1 - столбцы (4)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    System.Console.WriteLine();
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);