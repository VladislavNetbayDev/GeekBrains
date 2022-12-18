// Задача 2: Задайте массив. 
// Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] numbers = GenerateArray(15, -10, 10);
System.Console.WriteLine("Сгенерированный массив");
PrintArray(numbers);
int value = foundValue("Какое значение будем искать?");

if (isFound(numbers, value)) System.Console.WriteLine("Значение есть");

else System.Console.WriteLine("Значения нет");

bool isFound(int[] numbers, int value)
{
    foreach (var item in numbers)
    {
        if(item == value)
        {
            return true;
        }
    }
    return false;
}

int foundValue(string message)
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