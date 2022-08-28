/*
void Method1()
{
    Console.WriteLine("hi");
}
*/
/*
Method1(); // вызвать метод

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");
*/
/*
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст", 4);
Method21(msg: "Текст", count: 4);
*/
/*
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/
/*
string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "Yi");
Console.WriteLine(res);
*/

/*
string Method5(int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;

    }
    return result;
}

string res = Method5(10, "Yi");
Console.WriteLine(res);
*/
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j} ");
    }
    Console.WriteLine();
}
*/
/*
string text = "Сегодня мы углубимся в тему и выделим 4 основных группы методов, а также будем использовать их на практике. "
+ "И познакомимся с новыми языковыми конструкциями, в частности, циклом.";

string Replace(string text, char oldVal, char newVal)
{
    string result = String.Empty;
    int len = text.Length;
    for (int i = 0; i < len; i++)
    {
        if (text[i] == oldVal) result = result + $"{newVal}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newTex = Replace(text, ' ', '_');
Console.WriteLine(newTex);
newTex = Replace(newTex, 'о', 'O');
Console.WriteLine(newTex);
*/


int[] arr = { 2, 3, 6, 3, 9, 5 };
void PrintArr(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelecSortMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPos]) minPos = j;
        }

        int temporary = array[i];
        array[i] = array[minPos];
        array[minPos] = temporary;
    }
}

void SelecSortMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPos]) maxPos = j;
        }

        int temporary = array[i];
        array[i] = array[maxPos];
        array[maxPos] = temporary;
    }
}

PrintArr(arr);
SelecSortMax(arr);
PrintArr(arr);
SelecSortMin(arr);
PrintArr(arr);