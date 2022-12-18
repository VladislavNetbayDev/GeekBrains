// Задача 1: Напишите программу, 
// которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

int inputValue(string message)
{
    System.Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());

}
bool CheckSize(int A, int B, int C)
{
    if(A+B > C)
    {
        return true;
    }
    return false;
}

int A = inputValue("Введите длину первой стороны");
int B = inputValue("Введите длину второй стороны");
int C = inputValue("Введите длину третьей стороны");

if (CheckSize(A, B, C) && CheckSize(B, C, A) && CheckSize(A, C, B))
{
    System.Console.WriteLine("Да, такой треугольник может существовать");
}
else
{
    System.Console.WriteLine("Нет, такой треугольник не может существовать");
}
