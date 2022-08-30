// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int ExtentNum(int a, int b)
{
    int res = a;

    for (int i = 1; i < b; i++)
    {
        res *= a;
    }
    return res;
}

// int res = ExtentNum(2, 4);
// Console.WriteLine(res);

Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int res = ExtentNum(a, b);
Console.WriteLine($"{a} в степени {b} равна {res}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumDigit(int num)
{
    int res = 0;
    int number = 0;

    while (num > 0)
    {
        number = num % 10;
        res = res + number;
        num = num / 10;
    }
    return res;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел равна {SumDigit(num)}");


/*
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

string[] CreateConsoleArray()
{
    Console.Write("Введите количество элементов массива: ");
    int count = Convert.ToInt32(Console.ReadLine());
    string[] arr = new string[count];
    for (int i = 0; i < count; i++)
    {
        Console.Write("Введите елемент массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArr(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("\b\b]");
}

string[] newArr = CreateConsoleArray();
PrintArr(newArr);

*/

