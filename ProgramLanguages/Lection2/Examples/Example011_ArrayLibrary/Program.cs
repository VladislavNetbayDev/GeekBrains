int [] array = new int[10]; // Создаём массив и указываем его размер, который изначально заполняется нулями
void FillArray(int [] collection) // Описываем метод заполнения массива
{
    int length = collection.Length; // задаём длину массива
    int index = 0; // задаем индекс первого элемента
    while(index < length) // условие, пока индекс меньше длины массива
    {
        collection[index] = new Random().Next(1, 10); // указываем как будем заполнять массив (рандомными числами от 1 до 10)
        index++; // увеличиваем индекс на единицу (выбираем следующее число)

    }
}

void PrintArray(int[] collection) // Описываем метод вывода на консоль массива
{
    int length = collection.Length;
    int index = 0; 
    while (index < length)
    {
        Console.WriteLine(collection[index]);
        index ++;
    }
}

int IndexOf(int[] collection, int find) // Описываем метод поиска индекса элемента массива, равного по значению с искомым
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // int position = -1 - Выводит на консоль цифру -1, если элемент с искомым значением не найден 
    while(index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // Останавливает поиск и выводит первый на консоль элемент с искомым значением (без этой команды выведет на печать последний элемент искомый)
        }
        index++;
    }
    return position;
}
FillArray(array); // Вызываем метод заполнения массива
PrintArray(array); // Вызываем метод вывода массива на консоль
Console.WriteLine(); // пустая строчка, не является частью вывода массива
int pos = IndexOf(array, 4); // Вызываем метод нахождения индекса элемента с искомым значением
Console.WriteLine(pos); // Выводим на консоль 



