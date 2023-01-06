// Частотный словарь это замена слова на символ и обратно. Применяется при архивировании

// Задача 3: Составить частотный словарь элементов 
// двумерного массива. Частотный словарь содержит информацию 
// о том, сколько раз встречается элемент входных данных. 
// Значения элементов массива 0..9
// Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

int [,] CreateFillArray(int m)
{
    int [,] array = new int[m, m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
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


// int [] Dictionary(int[,] array)
// {
//     int [] Dict = new int [10];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int l = 0; l < Dict.Length; l++)
//             {
//                 if(array[i, j] == l) 
//                 {
//                     Dict[l] ++;
//                 }
//             }
//         }
//     }
//     return Dict;
// }
int [] Dictionary(int[,] array)
{
    int [] Dict = new int [10];
    foreach (int item in array)
    {
        Dict[item]++;
    }
    return Dict;
}

void PrintList(int[]list)
{
    for (int i = 0; i < list.Length; i++)
    {
        System.Console.WriteLine(list[i]);
    }
}
int[,] matrix = CreateFillArray(4);
PrintArray(matrix);
PrintList(Dictionary(matrix));

