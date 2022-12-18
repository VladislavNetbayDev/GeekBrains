//  Задача 4: Напишите программу, 
//  которая будет создавать копию заданного массива 
//  с помощью поэлементного копирования.



int inputValue(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
    System.Console.WriteLine();
}
int [] CopyArray(int [] array)
{
    int [] array2 = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array2[0] = array[i];  
    }
    return array2;
}
int [] array = GenerateArray(7);
PrintArray(array);

int [] array2 = CopyArray(array);

PrintArray(array);
PrintArray(array2);