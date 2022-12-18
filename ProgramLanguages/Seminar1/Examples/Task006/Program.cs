// Вычисление модуля числа N
System.Console.WriteLine("Введите число N: ");
string inputN = Console.ReadLine();
int N = Convert.ToInt32(inputN);
if (N < 0)
{
    N = -N;
}

System.Console.WriteLine(N);


