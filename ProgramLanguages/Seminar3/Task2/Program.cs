// Задача 2: Напишите программу, 
// которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек 
//  в этой четверти (X и Y)

int inputValue(string message)
{
    System.Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}
int quater = inputValue("Введите номер четверти: ");
switch (quater)
{
    case 1:
        System.Console.WriteLine("Диапазон значений X > 0 && Y > 0");
        break;
    case 2:
        System.Console.WriteLine("Диапазон значений X < 0 && Y > 0");
        break;
    case 3:
        System.Console.WriteLine("Диапазон значений X < 0 && Y < 0");
        break;
    case 4:
        System.Console.WriteLine("Диапазон значений X > 0 && Y < 0");
        break;
    default:
        System.Console.WriteLine("Это не номер четверти");
        break;
}