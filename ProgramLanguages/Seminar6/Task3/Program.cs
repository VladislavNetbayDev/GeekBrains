// Задача 2: Напишите программу, 
// которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int inputValue(string message)
{
    System.Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int [] ToBinary(int arg)
{
    int [] number = new int[8];
    int count = 1;
    while (arg > 0)
    {
        int ostatok = arg % 2;
        number[number.Length - count] = ostatok;
        count++;
        arg = arg / 2;
    }
    return number;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
    System.Console.WriteLine();
}
int A = inputValue("Введите число: ");
PrintArray(ToBinary(A));
