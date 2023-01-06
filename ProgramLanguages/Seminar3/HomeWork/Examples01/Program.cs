// Напишите программу, 
// которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. 
// Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да



// int[] array = {1, 2, 8, 2, 1};
// if (array[0] == array[4] && array[1] == array[3])
//     System.Console.WriteLine("да");
// else System.Console.WriteLine("нет");


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
