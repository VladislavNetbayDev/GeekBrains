// Задача: Сумма чисел от 1 до N
int SumFor(int N)
{
    int result = 0;
    for (int i = 1; i <= N; i++)  
    {
        result += i;
    }
    return result;
}
int SumRecursia(int N)
{
    if (N == 0) return 0;
    else return N + SumRecursia(N - 1);
}
System.Console.WriteLine(SumFor(10));
System.Console.WriteLine(SumRecursia(10));