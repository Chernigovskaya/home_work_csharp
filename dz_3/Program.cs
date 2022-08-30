
// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
bool PalindromNum(int number)
{
    string num = number.ToString();
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] != num[num.Length - 1 - i]) return false;
    }
    return true;

}

Console.Write("Input Number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write(PalindromNum(number));
*/


void PalindromNum(int number)
{
    string num = number.ToString();
    if (num.Length == 5)
        if (num[0] == num[4] & num[1] == num[3])
            Console.WriteLine($"Number {num} is polindrom");
        else Console.WriteLine($"Number {num} is not polindrom");
    else Console.WriteLine("Введите пятизначное число");
}

Console.Write("Input Number: ");
int number = Convert.ToInt32(Console.ReadLine());

PalindromNum(number);


/*
//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double DistanceAB(int xA, int yA, int zA, int xB, int yB, int zB)
{
    double res = Math.Sqrt((xA - xB) * (xA - xB) + (yA - yB) * (yA - yB) + (zA - zB) * (zA - zB));
    return Math.Round(res, 2);
}

double result1 = DistanceAB(7, -5, 0, 1, -1, 9);
Console.WriteLine(result1);
double result2 = DistanceAB(3, 6, 8, 2, 1, -7);
Console.WriteLine(result2);
// Console.Write("Input x point A : ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input y point A : ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input z point A : ");
// int zA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input x point B : ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input y point B : ");
// int yB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input z point B : ");
// int zB = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Distance about points 'A' and 'B' = {DistanceAB(xA, yA, zA, xB, yB, zB)}");

*/

/*
//Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


void CubeNum(double n)
{
    int i = 1;
    while (i <= n)
    {
        double res = Math.Pow(i, 3);
        Console.Write($"{res}, ");
        i++;
    }
}
Console.Write("Input Number: ");
double num = Convert.ToDouble(Console.ReadLine());
CubeNum(num);
*/


