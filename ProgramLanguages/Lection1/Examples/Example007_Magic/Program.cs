// Задача: 

Console.Clear(); // Очисщает консоль от всего
// Console.SetCursorPosition(10, 4); // Указывает куда поставить курсор, путём отступа от левого и правого края 10 и 4 позиции соответственно
// Console.WriteLine("+"); // Ставит знак + в месте постановки курсора
int xa = 1; // Задали координаты точек
int ya = 1;
int xb = 1;
int yb = 30;
int xc = 30;
int yc = 30;

Console.SetCursorPosition(xa, ya); // Указывает место, куда будет поставлен курсор, путём отступа от краёв на соответствующие значения 
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = xb; // Определяем переменную x и кладём в неё заданные значения
int count = 0;
while(count < 10)
{
    int what = new Random().Next(0, 3); // [0;3) 0 1 2 Полуинтервал [)
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count ++;
}




