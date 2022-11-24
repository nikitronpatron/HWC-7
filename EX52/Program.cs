// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());
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

void AverageValueColumns(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sumColumnElements = 0;
        double average = 0;
        double count = array.GetLength(0);

        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumColumnElements += array[j, i];
            average = sumColumnElements / count;
        }
        Console.Write($"{average:f1} ");
    }
}

int[,] myArray = GetArray(rows, columns, 0, 9);
PrintArray(myArray);
Console.WriteLine();
AverageValueColumns(myArray);