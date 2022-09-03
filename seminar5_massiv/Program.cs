// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
int[] CreateRandomArray(int n, int nimVal, int maxVal)
{
    int[] arr = new int[n]; // выделили пвмять для массива длиной n
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(nimVal, maxVal + 1);
    }
    return arr;
}

void PrintArr(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("\b]");
}
// PrintArr(CreateRandomArray(8, 0, 1));
/*
int FindNegativSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i];
    }
    return sum;
}
*/
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] arr = CreateRandomArray(size, min, max);
PrintArr(arr);

/*
int[] newArr = CreateRandomArray(size, min, max);
PrintArr(newArr);
Console.WriteLine($"Sum of negative elements is {FindNegativSum(newArr)}");
*/

// Напишите программу для замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] ReplaseSign(int[] array)
{
    int len = array.Length;
    int[] newArr = new int[len];
    for (int i = 0; i < len; i++)
    {
        newArr[i] = array[i] * (-1);
    }
    return newArr;
}
int[] arr = CreateRandomArray(size, min, max);
PrintArr(arr);
int[] newArr = ReplaseSign(arr);
PrintArr(newArr);
*/
/*
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.


bool FindValue(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}

Console.Write("Input value: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindValue(arr, num));
*/
/*
// Задайте одномерный массив из 15 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].
int FindCountEl(int[] array, int minSeg, int maxSeg)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > minSeg & array[i] < maxSeg + 1)
            count++;
    }
    return count;
}

Console.Write("Input beginning of  segment: ");
int minSeg = Convert.ToInt32(Console.ReadLine());
Console.Write("Input end of  segment: ");
int maxSeg = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"In segment count elements is {FindCountEl(arr, minSeg, maxSeg)}");

*/

//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] FindProductPairs(int[] arr)
{
    int len = arr.Length;
    int[] newArr = new int[(len / 2) + len % 2];
    for (int i = 0; i < len / 2 + len % 2; i++)
    {
        newArr[i] = arr[i] * arr[len - i - 1];
    }
    return newArr;
}

int[] newArr = FindProductPairs(arr);
PrintArr(newArr);