﻿// Задача: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых <=3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не пользоваться коллекциями, только массивами.

string[] arrayStart = new string[4] { "says", "257", "hi23", "1223"}; // Задаем изначальный массив размерностью 4 строки
string[] arrayFinish = new string[arrayStart.Length]; // Задаем массив, соответствующий ТЗ
int symbolsOfString = 3; // Задаем размер строки, соответствующий ТЗ

