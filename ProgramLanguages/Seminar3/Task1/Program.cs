// 1. Напишите программу, 
// которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 или Y ≠ 0 
// и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

int Prompt(string message) // Функция вывода приглашения и ввода целого числа
{
    System.Console.WriteLine($"{message}"); // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // Ввод числа
}

bool ValidateQuarter(int X, int Y) // Проверка на корректность данных // х и у должны быть отличны от 0.
{
    if (X == 0 || Y == 0) // х или у равен 0
    {
        System.Console.WriteLine("Одна из координат равна 0"); // Проверка не пройдена
        return false;
    }
    return true; // Проверка пройдена
}
int GetQuarter (int X, int Y) // Получение четверти по координатам
{
    if (Y > 0 && X > 0)
    {
        return 1; // Первая четверть
    }
    if (Y> 0 && X < 0)
    {
        return 2; // Вторая четверть
    }
    if (Y < 0 && X < 0)
    {
        return 3; // Третья четверть
    }
    return 4; // Четвертая четверть
}
// Вывозы всех функций
int coordX = Prompt("Введите Х"); 
int coordY = Prompt("Введите Y");

if (ValidateQuarter(coordX, coordY))
{
    int quarter = GetQuarter(coordX, coordY);
    System.Console.WriteLine($"Полученная четверть {quarter}");
}