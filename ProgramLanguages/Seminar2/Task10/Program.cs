// Написать метод, который принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
int [] array = {4, 5, 6};
int find = array[1];
int index = 0;
int n = array.Length;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(array[index]);
        break;
    }
    index = index + 1;
}