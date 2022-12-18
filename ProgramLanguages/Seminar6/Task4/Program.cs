// Задача 3: Не используя рекурсию, 
// выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int inputValue(string message)
{
    System.Console.Write($"{message }");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}
int[] Fibonacci(int arg)
{
    int [] fibRow = new int[arg];
    fibRow[0]= 0;
    fibRow[1] = 1;
    for (int i = 2; i < arg; i++)
    {
           fibRow[i] = fibRow[i - 1] + fibRow[i -2];
    }
    return fibRow;
}
PrintArray(Fibonacci(inputValue("Введите число: ")));