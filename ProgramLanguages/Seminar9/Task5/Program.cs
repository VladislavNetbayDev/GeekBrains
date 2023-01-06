// Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”
bool PowerTwo(int number)
{
    if(number % 2 != 0)
    {
        return false;
    }
    if (number == 2)
    {
        return true;
    }
    number = number / 2;
    return PowerTwo(number);
}
System.Console.WriteLine(PowerTwo(45));
System.Console.WriteLine(PowerTwo(64));
System.Console.WriteLine(PowerTwo(12));

                               // Второй вариант
// bool PowerTwo(int number)
// {
//     if (number == 2)
//     {
//         return true;
//     }
//     return (number % 2 == 0) && PowerTwo(number / 2);
// }
// System.Console.WriteLine(PowerTwo(45));
// System.Console.WriteLine(PowerTwo(64));
// System.Console.WriteLine(PowerTwo(12));