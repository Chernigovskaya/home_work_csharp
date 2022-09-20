/*
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
void ShowNum(int num)
{
    if (num > 1) ShowNum(num - 1);
    Console.Write(num + " ");
}

void ShowNumMax(int num)
{
    Console.Write(num + " ");
    if (num > 1) ShowNumMax(num - 1);
}
ShowNum(5);
Console.WriteLine();
ShowNumMax(6);
*/

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int SumNumber(int num)
{
    if (num > 0) return SumNumber(num / 10) + num % 10;
    else return 0;
}
Console.WriteLine(SumNumber(5734));
*/
/*
//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

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

// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
double RaiseDegree(double a, int b)
{
    if (b > 0) return a * RaiseDegree(a, b - 1);
    if (b < 0) return (1 / a * RaiseDegree(a, b + 1));
    else return 1;
}
Console.WriteLine(RaiseDegree(2, 3));
Console.WriteLine(RaiseDegree(2, -3));


