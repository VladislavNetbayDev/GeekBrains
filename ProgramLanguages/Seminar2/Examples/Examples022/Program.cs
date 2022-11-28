// Задача 22. Найти расстояние между точками в пространстве 2D/3D

// 1. Откуда берутся данные
// 2. Вычисление
// 3. печать результата

// 1. Получаем данные
double GetValue(string text) //string text - строка формальный аргумент (не знаем какой будет)
{
    Console.Write(text + ": "); // Ввод через консоль значений переменных. Text
    double value = Convert.ToDouble(Console.ReadLine()); // ReadLine Считывание данных из консоли
    return value;
}
// 3. Печать результата
void Print(double ax, double ay, double bx, double by, double result)// Void Метод, который ничего не возвращает
{
    string output = "|A(" + ax + ", " + ay + "); B(" + bx + ", " + by + ")| = " + result;
    Math.Round(result, 2);
    Console.WriteLine(output);
}

// 2. Вычисление
double GetDistance(double ax, double ay, double bx, double by)
{
    double x = (ax - bx) * (ax - bx);
    double y = Math.Pow(ay - by, 2);
    double result = Math.Sqrt(y + x); // Math.Sqrt(y+x) = (y+x)^2
    return result;

}

double ax = GetValue("ax"); //Фактический аргумент (ax), который будет подставлен вместо text
double ay = GetValue("ay");
double bx = GetValue("bx");
double by = GetValue("by");

double dis = GetDistance(ax, ay, bx, by);
Print(ax, ay, bx, by, dis);

