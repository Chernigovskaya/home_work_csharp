// Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*
int FindQadrant(double x, double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

// double x = 2;
// double y = -6;
// Console.WriteLine(FindQadrant(x, y));

Console.Write("Input X coopdinate: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y coopdinate: ");
double yA = Convert.ToDouble(Console.ReadLine());
int quadrant = FindQadrant(xA, yA);
Console.WriteLine(quadrant);
*/

//Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

/*
void FindCoordinate(int num)
{
    if (num == 1) Console.WriteLine("координаты Х и У больше 0");
    else if (num == 2) Console.WriteLine("координаты Х - меньше 0, У - больше 0");
    else if (num == 3) Console.WriteLine("координаты Х и У меньше 0");
    else if (num == 4) Console.WriteLine("координаты Х - больше 0, У меньше 0");
    else Console.WriteLine("Нет такой четверти. Исправьтесь");
}


Console.Write("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());
FindCoordinate(num);
*/

/*
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

void SguaresNum(int n)
{
    int i = 1;
    while (i <= n)
    {
        int res = i * i;
        Console.Write($"{res}, ");
        i++;
    }
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
SguaresNum(num);

*/

//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.

double DistanceAB(int xA, int yA, int xB, int yB)
{
    double res = Math.Sqrt((Math.Abs(xA) - Math.Abs(xB)) * (Math.Abs(xA) - Math.Abs(xB)) + (Math.Abs(yA) - Math.Abs(yB)) * (Math.Abs(yA) - Math.Abs(yB)));
    return (res);
}

double result = DistanceAB(2, 6, 8, 5);
Console.WriteLine(result);

