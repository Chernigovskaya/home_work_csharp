/*
//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
int FindSum(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
        sum += i;
    return sum;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of numbers from 1 to {num} is {FindSum(num)}");
*/

/*
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int FindLen(int num)
{
    int len = 0;
    while (num > 0)
    {
        num /= 10;
        len++;
    }
    return len;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"in a number {num} digist is {FindLen(num)}");
*/
/*
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
int CompositionNumber(int n)
{
    int res = 1;
    for (int i = 1; i <= n; i++)
        res = res * i;
    return (res);

}
Console.Write("Input number: ");
int res = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Composition of numbers from 1 to {res} is {CompositionNumber(res)}");
*/

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.


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
int[] newArr = CreateRandomArray(6, 1, 6);
PrintArr(newArr);