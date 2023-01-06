// Напишите программу, 
// которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int inputValue(string message) // Метод ввода числа
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Delta(int coordinate1, int coordinate2) // Метод нахождения дельты
{
    int delta = coordinate2 - coordinate1;
    return delta;
}

int Product(int delta)
{
    int product = delta * delta;
    return product;
}

int coordinatex1 = inputValue("Введите число coordinatex1: ");
int coordinatex2 = inputValue("Введите число coordinatex2: ");
int coordinatey1 = inputValue("Введите число coordinatey1: ");
int coordinatey2 = inputValue("Введите число coordinatey2: ");
int coordinatez1 = inputValue("Введите число coordinatez1: ");
int coordinatez2 = inputValue("Введите число coordinatez2: ");

int deltax = Delta(coordinatex1, coordinatex2);
int deltay = Delta(coordinatey1, coordinatey2);
int deltaz = Delta(coordinatez1, coordinatez2);


int productx = Product(deltax);
int producty = Product(deltay);
int productz = Product(deltaz);

double distance = Math.Sqrt(productx + producty + productz);
System.Console.WriteLine($"distance = {distance:f2}");