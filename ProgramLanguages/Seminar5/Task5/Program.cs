// Задача 4: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int inputValue(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int length, int minRange, int maxRange)
{
    int[] numbers = new int[length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(minRange, maxRange + 1);
    }
    return numbers;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "\t");
    }
    System.Console.WriteLine();
}

int [] multi(int [] Array)
{
    int [] result = new int [Array.Length/2 + Array.Length%2];
    result[result.Length - 1] = Array[result.Length - 1];
    for (int i = 0; i < Array.Length/2; i++ )
    {
        result[i] = Array[i] * Array[Array.Length -1 -i];
    }
    return result;
}

int length = inputValue("Input length of array");
int minArray = inputValue("Input min of array");
int maxArray = inputValue("Input min of array");

int[] array = GenerateArray(length, minArray, maxArray);
PrintArray(array);
System.Console.WriteLine();
PrintArray(multi(array));
// System.Console.WriteLine($"Count of numbers is {multi(array)}");