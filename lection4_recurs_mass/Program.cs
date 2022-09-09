

//string[,] table = new string[2, 5];
// String.Empty
// table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]  table[0,1]  table[1,2]  table[1,3]  table[1,4]
/*
table[1, 2] = "word";

for (int rows = 0; rows < 2; rows++)
{
    for (int colums = 0; colums < 5; colums++)
    {
        Console.WriteLine($"-{table[rows, colums]}-");
    }
}
*/
/*
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}


int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/
/*
//factorial

double Factorial(int n)
{
    //1!=1, 0!=1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}

Console.WriteLine(Factorial(13));


// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine(Factorial(i));
// }
*/
/*
//fibonachi
// f(1)=1 f(2) = 1 f(n) = f(n-1) + f(n-2 )

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}


Console.WriteLine(Fibonacci(7));
*/

//обход директории

