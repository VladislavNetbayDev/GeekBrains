
                            // Первый вариант 

int [] array = new int[10]; // Создаём массив, который изначально заполняется нулями
void FillArray(int [] collection) // Метод, описывающий заполнение массива
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;

    }
}

void PrintArray(int[] col) // col - название аргумента (переменной) вместо collection, просто надо привыкать называть по разному. Метод, описывающий вывод на печать массива (вывод на консоль)
{
    int count = col.Length;
    int position = 0; // position == index - просто назвали по другому. 
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position ++;
    }
}

int IndexOf(int[] collection, int find) // Поиск индекса элемента массива, равного по значению с искомым
{
    int count = collection.Length;
    int index = 0;
    int position = 0; // int position = -1 - Выводит на консоль цифру -1, если элемент с искомым значением не найден 
    while(index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
FillArray(array); // Заполнить массив
PrintArray(array); // Вывести массив на консоль
Console.WriteLine(); // пустая строчка, не является частью вывода массива
int pos = IndexOf(array, 4); // Искомое значение элемента
Console.WriteLine(pos);


