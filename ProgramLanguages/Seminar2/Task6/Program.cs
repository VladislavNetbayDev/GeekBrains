// 3.1. Напишите программу, 
// которая будет принимать на вход пять чисел и 
// выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4 

int inputValue(string message)
{
    System.Console.WriteLine($"{message}");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
double sum = 0.0;

int count = inputValue("add count: ");
int index = 0;
 while (index < count)
 {
    int value = inputValue($"add {index} number");
    sum = sum + value;
    index++;
 }
double avg = sum / index;
System.Console.WriteLine($"sum = {sum}");
System.Console.WriteLine($"average = {avg:f2}");