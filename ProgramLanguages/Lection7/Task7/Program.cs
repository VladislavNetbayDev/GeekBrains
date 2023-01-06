// Игра в пирамидки. Построение ханойской башни. 

void Towers(string with = "1", string on = "3", string some = "2", int count = 3) // string with = "1" - Рабочая башня, из которой мы вытаскиваем круги. string on = "3" - башня, на которой должны оказаться круги. string some = "2" - промежуточная башня, int count = 3 - кол-во блинов
{
 if (count > 1) Towers(with, some, on, count - 1);
 Console.WriteLine($"{with} >> {on}");
 if (count > 1) Towers(some, on, with, count - 1);
}
Towers();