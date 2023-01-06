// Задача: Собрать строку с числами от a до b, a <= b
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result = result + $"{i} ";
    }
    return result;
}

string NumbersRecursia(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRecursia(a+1, b);
    else return string.Empty;
}
System.Console.WriteLine(NumbersFor(1, 10));
System.Console.WriteLine((NumbersRecursia(1, 10)));