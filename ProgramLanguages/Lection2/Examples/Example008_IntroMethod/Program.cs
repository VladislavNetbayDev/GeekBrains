                                    // Старый способ

// int a1 = 112125;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 2311;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23111;
// int c3 = 313;

// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;

// Console.WriteLine(max);

                                        // Новый способ с применением методов

int Max(int a, int b, int c)  // Описываем метод
{
    int result = a;
    if (b>result) result = b;
    if (c>result) result = c;
    return result; // Return завершает выполнение метода и записывает результат в переменную result, а именно максимальное число
}


int a1 = 112125; // Вводим значения переменных
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 2311167;
int c3 = 313;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)); // Находим максимум среди каждой тройки чисел. находим максимум среди 3 максимальных
Console.WriteLine(max); // Получили максимум из всех чисел



