// Задача 4: Напишите программу, 
// которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
int inputValue(string message)
{
    System.Console.Write($"{message}");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int number = inputValue("Введите число: ");
int start = 1;

int mod = number;
if (mod < 0)
{
    mod = -mod;
}

while (start <= mod)
{
    int square = start * start;
    System.Console.WriteLine(square);
    start++;
}

