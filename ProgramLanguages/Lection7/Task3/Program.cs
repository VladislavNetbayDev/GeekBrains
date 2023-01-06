// Задача: Найти факториал числа
// Вариант с функцией
int FactorialFor(int N)
{
    int result = 1;
    for (int i = 1; i <= N; i++)
    {
        result *= i;
    }
    return result;
}
// Рекурсивный вариант
int FactorialReculsia(int N)
{
    if (N == 1)
    {
        return 1;
    }
    else 
    {
        return N * FactorialReculsia(N - 1);
    }
}
System.Console.WriteLine(FactorialFor(10));
System.Console.WriteLine(FactorialReculsia(10));