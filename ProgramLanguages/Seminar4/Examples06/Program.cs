// Задача *: Напишите программу, 
// которая из массива случайных чисел. 
// Ищет второй максимум (число меньше максимального элемента, 
// но больше всех остальных). Постарайтесь сделать одним циклом 
// [1, 3, 5, 6, 6, 4] -> 5
int [] FillArray(int Length, int MinRange, int MaxRange)
{
    int [] array = new int[Length]; 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(MinRange, MaxRange+1);
    }
    return array;
}
void PrintArray(int [] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        System.Console.Write(array[j] + " ");
    }
}
int InputValue(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int MaxValueIndex(int[] array)
{
    int MaxValue = array[0];
    int MaxValue2 = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (MaxValue < array[i])
        {
            MaxValue = array[i];
        }
    }
    
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == MaxValue)
        {
            continue; // Если условие выполняется, команда continue заменяет else и завершает цикл
        }
        if (MaxValue2 < array[i])
        {
            MaxValue2 = array[i];
        }
    }
    return MaxValue2;
}

int Range = InputValue("Введите длину массива: ");

int MinValue = InputValue("Введите минимальное значение: ");

int MaxValue = InputValue("Введите максимальное значение: ");

int [] arr = FillArray(Range, MinValue, MaxValue);

PrintArray(arr);

System.Console.WriteLine("Второй по величине элемент массива равен: " + MaxValueIndex(arr));
