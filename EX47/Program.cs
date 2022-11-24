// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    for(int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*(10);
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f2} ");
        }
        Console.WriteLine();
    }
}

double[,] myArray = GetArray(rows, columns);
PrintArray(myArray);