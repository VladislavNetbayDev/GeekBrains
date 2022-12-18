// Задача 3: Задайте одномерный массив из 10 случайных чисел 
// в диапазоне от 1 до 200. 
// Найдите количество  двузначных элементов массива. 
// Пример для массива из 5, а не 10 элементов. 
// В своём решении сделайте для 10
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


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

int Search(int[] array, int minLine, int maxLine)
{
    int counter = 0;
    foreach (int item in array)
    {
        if (item >= minLine && item <= maxLine)
        {
            counter++;
        }
    }
    return counter;
}

int length = inputValue("Input length of array");
int minArray = inputValue("Input min of array");
int maxArray = inputValue("Input min of array");

int minLine = inputValue("Input start of line");
int maxLine = inputValue("Input finish of line");

int[] array = GenerateArray(length, minArray, maxArray);
PrintArray(array);


System.Console.WriteLine($"Count of numbers is {Search(array, minLine, maxLine)}");