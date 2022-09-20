// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

/*
int[,] ChangeRows(int[,] array, int row1, int row2)
{
    if (row1 >= 0 && row1 < array.GetLength(0) && row2 >= 0 && row2 < array.GetLength(0) && row1 != row2)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    return array;
}

*/
int[,] myArr = CreateRandom2dArray();
Show2dArray(myArr);
// Show2dArray(ChangeRows(myArr, 2, 4));
/*
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] ChangeRowsCols(int[,] arr)
{

    if (arr.GetLength(0) == arr.GetLength(1))
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = i + 1; j < arr.GetLength(1); j++)
            {
                int temp = arr[i, j];
                arr[i, j] = arr[j, i];
                arr[j, i] = temp;
            }
        }
    return arr;
}
Show2dArray(ChangeRowsCols(myArr));
*/
/*
//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] DelRowColMinEl(int[,] array)
{
    int[] minPos = { 0, 0 };

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < array[minPos[0], minPos[1]])
            {
                minPos[0] = i;
                minPos[1] = j;
            }

}
*/

int[,] table = new int[4, 4];
FillArrayRandom(table);
PrintArray(table);
Console.WriteLine();
NumberRowMinSumElements(table);


// Функция вывода номера строки (не индекса) с наименьшей суммой элементов 
void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < table.GetLength(1); i++)
    {
        minRow += table[0, i];
    }
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}

// Функция вывода двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Функция заполнения массива рандомно числами от 1 до 9
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}