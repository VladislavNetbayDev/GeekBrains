// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
System.Console.WriteLine("Введите число N");
string value = Console.ReadLine();
int N = Convert.ToInt32(value);
for (int A = 1; A <= N; A ++)
{
    if (A % 2 ==0)
    {
        System.Console.Write($"Список четных чисел от 1 до {N}");
        System.Console.WriteLine(A);
    }
}
