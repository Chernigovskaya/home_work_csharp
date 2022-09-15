// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of cols: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    double[,] newArray = new double[rows, cols];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            newArray[i, j] = new Random().Next(minVal, maxVal + 1) + random.NextDouble();

    return newArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i, j], 1) + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}


double[,] myArr = CreateRandom2dArray();
Show2dArray(myArr);
*/


/*
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray(int rows, int cols, int minVal, int maxVal)
{

    int[,] newArray = new int[rows, cols];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            newArray[i, j] = new Random().Next(minVal, maxVal + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindElement(int[,] arr, int i, int j)
{
    if (i > arr.GetLength(0) || j > arr.GetLength(1))
        Console.WriteLine("такого элемента нет в массиве");
    else
        Console.WriteLine($"значение элемента {i} строки и {j} столбца равно {arr[i - 1, j - 1]}");
}




int[,] myArr = CreateRandom2dArray(5, 5, -10, 10);
Show2dArray(myArr);
FindElement(myArr, 2, 1);
FindElement(myArr, 2, 5);
FindElement(myArr, 2, 6);

*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of cols: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, cols];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            newArray[i, j] = new Random().Next(minVal, maxVal + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void DeltaSumArr(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double middle = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            middle = middle + arr[i, j];
        }
        middle = middle / arr.GetLength(0);
        Console.Write($"{middle:f2}  ");
    }
}

int[,] myArr = CreateRandom2dArray();
Show2dArray(myArr);
DeltaSumArr(myArr);