// Задача 4: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным. 
// Не использовать строки

// 6 -> да
// 7 -> да
// 1 -> нет

int InputValue(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}





int numberOfTheDay = InputValue("Введите цифру, обозначающую день недели: ");
if (numberOfTheDay > 0 && numberOfTheDay < 8)
{
    if (numberOfTheDay > 5 && numberOfTheDay < 8)
    {
        System.Console.WriteLine("Это выходной день");
    }
    else System.Console.WriteLine("Это рабочий день");
}
else System.Console.WriteLine($"Цифра {numberOfTheDay} не обозначает день недели");