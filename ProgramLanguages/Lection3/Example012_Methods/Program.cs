                            // // Метод 1. Ничего не возвращает и не принимает

// void Method1() // Ничего не возвращают и ничего не принмают
// {
//     Console.WriteLine( "Автор ..."  );
// }
// Method1();  // Как вызываются подобные методы


                            // // Метод 2. Ничего не возвращает, но принимает аргументы
// void Method2(string msg) // Ничего не возвращают, но принимают (string - строка, msg (message) название аргумента)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg:"Текст сообщения");


// void Method21(string msg, int count) // count - для вывода на экран определенного кол-ва message (msg) Ничего не возвращают, но принимают (string - строка)
// {
    
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Текст сообщения", count: 4);
// Method21(count: 4, msg: "новый текст");



                            // // Метод 3.Возвращает, но не принимает аргументы

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
//Console.WriteLine(year);

                            //Метод 4. Принимает и возвращает

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;// String.Empty - пустая строка. Переменная куда будем класть конечный результат
    
//         while (i < count)
//         {
//             result = result + text;
//             i++;
//         }
//         return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

                                                // Пример1: 

// string Method4(int count, string text)
// {
//     string result = String.Empty;// Переменная куда будем класть конечный результат
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);

                                                // Пример 2: Цикл в цикле

for (int i = 2; i <= 10; i++) //  i - первое число. Таблица умножения
{
    for (int j = 2; j <= 10; j++) // j - второе число 
    {
        Console.WriteLine($"{i} x {j} = {i * j}"); // Вывод умножение на отдельное число (Интерполяция строк)
    }
    Console.WriteLine();// Переход на новую строку, чтобы в выводе умножение на новое число шло отдельно
}


// Функции в программировании. Выстроить массив по возрастанию 28:30/ 36:10
// int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};



