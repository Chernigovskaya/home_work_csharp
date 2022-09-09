/*
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void InputNum()
{
    Console.Write("Введите колличество чисел: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    int[] num = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        num[i] = Convert.ToInt32(Console.ReadLine());
        if (num[i] > 0) count++;
    }
    Console.WriteLine($"Кол-во чисел > 0 равно: {count}");
}
InputNum();
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

void PointIntersection(double k1, double b1, double k2, double b2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = k1 * x + b1;
    if (k1 == k2 & b1 == b2) Console.WriteLine($"Прямые совпадают");
    else if (k1 == k2) Console.WriteLine($"Прямые параллельны");
    else Console.WriteLine($"Точка пересечения двух прямых:({x}; {y})");
}

PointIntersection(k1, b1, k2, b2);
