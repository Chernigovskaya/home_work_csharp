// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

/*
int ShowSecondDigit(int number)
{
    int dec = number % 100;
    int second = dec / 10;
    return second;
}
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = ShowSecondDigit(number);
Console.WriteLine(result);
*/

/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
void ShowThirdDigit(string number)
{
    char[] three = number.ToCharArray();
    if (number.Length > 2) Console.WriteLine($"Третья цифра в числе {number} равна {number[2]}");
    else Console.WriteLine($"Третьей цифры в числе {number} нет");

}
Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
string numberString = Convert.ToString(number);
ShowThirdDigit(numberString);

// подскажите, пож-та, запрашивается ведь от пользователя строка? ее можо как то перевести сразу в массив?
// Всяко пробую, только так получается, но кажется, что лишнее действия делаю (это int number = Convert.ToInt32(Console.ReadLine());
*/

/*
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

void Weekend(int num)
{
    if (num == 6 ^ num == 7) Console.WriteLine("Да! Это выходной");
    else Console.WriteLine("Нет! Это рабочий день");
}

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
Weekend(dayNumber);
*/

