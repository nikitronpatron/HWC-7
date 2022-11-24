// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Enter the number of rows and columns");
int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Enter the row and column of the element");
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

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

void GetNumberFromArray(int[,] array, int m, int n)
{
    if(m <= array.GetLength(0) && n <= array.GetLength(1))
    {
        Console.WriteLine(array[m - 1, n - 1]);
    }
    else
    {
        System.Console.WriteLine("There is no such element");
    }
}

int[,] myArray = GetArray(rows, columns, 0, 9);
PrintArray(myArray);
Console.WriteLine();
GetNumberFromArray(myArray, row, column);
