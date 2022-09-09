
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateArray(int n, int min, int max)
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

*/
/*
int CountEvenNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}

int[] arr = CreateArray(10, 100, 1000);
PrintArray(arr);
Console.WriteLine($"Count even numbers in massiv is {CountEvenNum(arr)}");
*/

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int SumElOddPos(int[] arr)
{
    int sum = 0;

    for (int i = 1; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}
int[] arr = CreateArray(6, -0, 10);
PrintArray(arr);
Console.WriteLine(SumElOddPos(arr));

*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray(int n, int min, int max)
{
    double[] arr = new double[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(min, max + 1) + new Random().NextDouble();
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]:f2} ");
    }
    Console.WriteLine();
}

double DeltaMaxMin(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    double res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
        res = Math.Round(max - min, 2);
    }
    return res;
}

double[] arr = CreateArray(6, 0, 10);
PrintArray(arr);
Console.WriteLine(DeltaMaxMin(arr));