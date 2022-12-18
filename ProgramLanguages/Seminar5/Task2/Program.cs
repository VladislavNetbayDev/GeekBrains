// Задача 1: Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] numbers = GenerateArray(15, -10, 10);
System.Console.WriteLine("Сгенерированный массив");
PrintArray(inverseElement(numbers));

int[] inverseElement(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = -numbers[i];
    }
    return numbers;
}

System.Console.WriteLine("Обработанный массив");
PrintArray(numbers);



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