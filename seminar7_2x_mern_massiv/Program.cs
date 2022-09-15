// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

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


int[,] myArr = CreateRandom2dArray();
Show2dArray(myArr);

/*
//Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

int[,] Create2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of cols: ");
    int cols = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, cols];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            newArray[i, j] = i + j;

    return newArray;
}
int[,] myArr = Create2dArray();
Show2dArray(myArr);
*/

/*
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] ChangeEvensToSquare(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i += 2)
        for (int j = 0; j < arr.GetLength(1); j += 2)
        {
            arr[i, j] = arr[i, j] * arr[i, j];
        }
    return arr;
}

int[,] myNewArr = ChangeEvensToSquare(myArr);
Show2dArray(myNewArr);
*/
//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int SumMainDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < Math.Min(array.GetLength(0), array.GetLength(1)); i++)
        sum += array[i, i];
    return sum;
}

int sum = SumMainDiagonal(myArr);
Console.WriteLine(sum);