// 20 задача 20:00
void result (int a){
    int b = a / 100 % 10;
    if (a > 99) Console.WriteLine(b);
    else Console.WriteLine("Третьей цифры нет");
}
result (12);

// // Написать метод, который выводит третью цифру заданного числа или сообщает, что третьей цифры нет
// int [] array = {7, 8};
// int find = array[2];
// int index = 0;
// int n = array.Length;
// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(array[index]);
//         break;
//     }
//     index = index + 1;
// }
