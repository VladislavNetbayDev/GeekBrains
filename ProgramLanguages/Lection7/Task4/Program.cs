// Вычислить a^n
// 1 Вариант
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= a;
    }
    return result;
}
int PowerRec (int a, int n)
{   //return n == 0 ? 1 : PowerRec(a, n-1) * a; Запись в одну строку то, что ниже написано в 2 строки
    if (n == 0) return 1;
    else 
    {
        return PowerRec(a, n-1) * a;
    }
}