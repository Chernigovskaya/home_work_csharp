/*
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"первое число {number1} больше второго {number2}");
}
else
{
    Console.WriteLine($"второе число {number2} больше первого {number1} ");
}
*/


/*
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int maxim = number1;
if (number2 > number1 & number2 > number3)
{
    maxim = number2;
}
if (number3 > number1 & number3 > number2)
{
    maxim = number3;
}
Console.WriteLine($"{maxim} - максимальное число");

*/


/*
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"Да! {number} - это число четное");
}
else
Console.WriteLine($"Нет! {number} не является четным числом");
*/

/*
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int start_num = 1;
while(start_num <= number)
{
    if (start_num % 2 == 0)
        Console.Write(start_num + " ");
        start_num ++;
}
*/

