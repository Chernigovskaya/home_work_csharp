/*
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

int[] ReverseArr(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
    return array;
}

int[] ReverseArr1(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j / 2; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}


Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] arr = CreateRandomArray(size, min, max);
PrintArr(arr);
Console.WriteLine(ReverseArr1(arr));
PrintArr(arr);
Console.WriteLine(ReverseArr(arr));
PrintArr(arr);
*/


//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
string Dec2Bin(int num)
{
    string binNum = "";
    while (num > 0)
    {
        binNum = Convert.ToString(num % 2) + binNum;
        num = num / 2;
    }
    return binNum;
}
int num = 1235;
Console.WriteLine($" Число {num} в двоичной системе счисления {Dec2Bin(num)} ");



/*
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//F(i) = F(i - 1) + F(i - 2)
int[] Fibonachi(int count, int num1, int num2)
{
    int[] arr = new int[count];
    arr[0] = num1;
    arr[1] = num2;
        for (int i = 2; i < count; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2];
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
int[] fib = Fibonachi(8, 2, 5);
PrintArr(fib);
*/

/*
//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник сo сторонами такой длины.

bool IsTriangle(int a, int b, int c)
{
    if (a < c + b & b < a + c & c < a + b) return true;
    return false;
}
Console.WriteLine(IsTriangle(2, 3, 9));
Console.WriteLine(IsTriangle(2, 3, 4));
*/