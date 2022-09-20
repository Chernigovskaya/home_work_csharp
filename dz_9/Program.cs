// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNumMN(int m, int n)
{
    if (m <= n)
    {
        Console.Write(m + " ");
        if (m < n) ShowNumMN(m + 1, n);
    }
    if (m > n)
    {
        Console.Write(n + " ");
        if (n < m) ShowNumMN(m, n + 1);
    }
}
ShowNumMN(1, 3);
Console.WriteLine();
ShowNumMN(6, 3);
*/

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SunNumMN(int m, int n)
{
    if (m < n) return m + SunNumMN(m + 1, n);
    if (n < m) return m + SunNumMN(m - 1, n);
    else return m;
}
Console.WriteLine(SunNumMN(1, 15));
Console.WriteLine(SunNumMN(4, 8));
Console.WriteLine(SunNumMN(10, 8));


//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.WriteLine(Akkerman(3, 2));
Console.WriteLine(Akkerman(0, 2));
Console.WriteLine(Akkerman(4, 0));