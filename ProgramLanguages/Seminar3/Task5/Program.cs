// Задача 5*: Напишите программу, 
// которая генерирует последовательность случайных чисел 
// из 10 элементов в диапазоне от 1 до 10, 
// и подсчитывает, сколько сгенерировалось чисел больше 5.

int [] array = new int [10];
int numQuant = 0;
for (int i = 0; i < array.Length; i++)
{
    int numbers = new Random().Next(1, 10);
    array[i] = numbers;
    System.Console.WriteLine(numbers);
    if (array [i] > 5)
    {
       numQuant++;
    } 
}
System.Console.WriteLine($"Количество значение больше 5 равно {numQuant}");