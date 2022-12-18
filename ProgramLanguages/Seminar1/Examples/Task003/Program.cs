Console.Write ("Введите номер дня недели ");
string inputValue = Console.ReadLine();
int value = Convert.ToInt32(inputValue);
// Первый вариант
// if (value == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if (value == 2)
// {
//     Console.WriteLine("Вторник");
// }
// else if (value == 3)
// {
//     Console.WriteLine("Среда");
// }
// else if (value == 4)
// {
//     Console.WriteLine("Четверг");
// }
// else if (value == 5)
// {
//     Console.WriteLine("Пятница");
// }
// else if (value == 6)
// {
//     Console.WriteLine("Суббота");
// }
// else if (value == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// Второй вариант
switch (value)
{
    case 1 : System.Console.WriteLine("понедельник"); break; 
    case 2 : System.Console.WriteLine("вторник");break; 
    case 3 : System.Console.WriteLine("среда"); break; 
    case 4 : System.Console.WriteLine("четверг"); break; 
    case 5 : System.Console.WriteLine("пятница"); break; 
    case 6 : System.Console.WriteLine("суббота"); break; 
    case 7: System.Console.WriteLine("воскресенье"); break; 
    default : System.Console.WriteLine("отсутствует"); break;
}
