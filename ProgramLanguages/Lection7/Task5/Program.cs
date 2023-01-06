// Вывести слова, содержащие определенное количество букв
// Первый вариант
// char[] s = {'а', 'и', 'c', 'в'};
// int length = s.Length;
// int n = 1;
// for (int i = 0; i < length; i++) // Содержит 1 букву
// {
//     for (int j = 0; j < length; j++) // Содержит 2 буквы
//     {
//         for (int k = 0; k < length; k++) // Содержит 3 буквы
//         {
//             for (int l = 0; l < length; l++) // Содержит 4 буквы
//             {
//                 for (int m = 0; m < length; m++) // Содержит 5 букв
//                 {
//                     System.Console.WriteLine($"{n++, -5} {s[i]} {s[j]} {s[k]} {s[l]} {s[m]}");
//                 }
//             }
//         }
//     }
// }
// Второй вариант
void FindWords(string alphabet, char[] word, int length = 0)
{
 if (length == word.Length)
 {
 Console.WriteLine($"{n++} {new String(word)}"); return;
 }
 for (int i = 0; i < alphabet.Length; i++)
 {
 word[length] = alphabet[i];
 FindWords(alphabet, word, length + 1);
 }
}
FindWords("аисв", new char[5]);

