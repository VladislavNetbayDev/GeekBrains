// Задача 6*: Напишите программу, 
// которая выводит первые заданные элемента 
// следующей последовательности: 
// -> 12
// 1 2 2 3 3 3 4 4 4 4 5 5 
int inputValue(string message)
{
    System.Console.Write($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

void Counter(int number)
{
    int index = 1; // кол-во выводимых переменных
    int indexLevel1 = 1; // Определяет что именно выводим (1б 22б 33 и т.д.)
    while (true)
    {
        int indexCounterLevel2 = 1;
        int counterLevel1 = indexLevel1; // Счетчик кол-ва выводимых переменных
        while (indexCounterLevel2 <= counterLevel1)
        {
            if (index <= number)
            {
                System.Console.WriteLine(counterLevel1);
                indexCounterLevel2++;
                index++;
            }
            else return;
        }
        indexLevel1++;
    }
}
int number = inputValue("Введите число: ");
Counter(number);




