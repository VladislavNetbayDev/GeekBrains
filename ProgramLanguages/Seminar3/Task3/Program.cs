// Задача 3: Напишите программу, 
// которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int inputValue(string message)
{
    System.Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = inputValue("Введите x1: ");
int x2 = inputValue("Введите x2: ");
int y1 = inputValue("Введите y1: ");
int y2 = inputValue("Введите y2: ");
int deltax = x1-x2;
int deltay = y1-y2;
double distance = Math.Sqrt(deltax * deltax + deltay * deltay);
System.Console.WriteLine($"distance = {distance:f2}");