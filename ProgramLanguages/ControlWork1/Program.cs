// Задача: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых <=3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не пользоваться коллекциями, только массивами.

string[] arrayStart = new string[4] { "says", "257", "hi23", "1223"}; // Задаем изначальный массив размерностью 4 строки
string[] arrayFinish = new string[arrayStart.Length]; // Задаем массив, соответствующий ТЗ
int symbolsOfString = 3; // Задаем размер строки, соответствующий ТЗ
void ArrayOfStrings(string[] arrayStart, string[] arrayFinish) // Задаем функцию поиска строк, соответствующих ТЗ
{
    int index = 0; // Задаем индекс строки, которую проверяем
    for (int i = 0; i < arrayStart.Length;i++) // Задаем оператор итерации
    {
        if (arrayStart[i].Length <= symbolsOfString) // Задаем условие проверки строки на соответствие ТЗ
        {
            arrayFinish[index] = arrayStart[i]; // Записываем строку, соответствующую ТЗ в массив
        }  
    }  
}

void PrintArray(string[] array) // Задаем функцию вывода массива на печать
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArrayOfStrings(arrayStart, arrayFinish); // Вызываем функцию поиска строк
PrintArray(arrayFinish); // Вызываем функцию вывода массива 
