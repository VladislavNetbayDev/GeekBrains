// 2. Даны два числа. Показать большее и меньшее число
int a = 9;
int b = 10;
int max = a;
int min = b;
if (b > max)
{
    max = b;
    min = a;
}
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);