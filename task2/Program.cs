// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] MatrixGeneration(int n, int m)
{
    Random rand = new Random();
    int[,] mass = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        int summ = 0;
        for (int j = 0; j < m; j++)
        {
            mass[i, j] = rand.Next(1, 10);
            summ += mass[i,j];
        }
        System.Console.WriteLine(summ);
    }
    return mass;
}

void MatrixDisplay(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write((matrix[i, j]) + "\t");
        }
        Console.WriteLine();
    }
}

int MinRowSummFinder(int[,] matrix)
{
    int rowNumber = 0, minSummOld = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int minSummNow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            minSummNow += matrix[i, j];
        }
        if (minSummNow < minSummOld)
        {
            rowNumber = i;
            minSummOld = minSummNow;
        }
        
    }
    return rowNumber;
}

int[,] matrix = MatrixGeneration(4, 4);
MatrixDisplay(matrix);
int minRow = MinRowSummFinder(matrix);
Console.WriteLine();
System.Console.WriteLine($"{minRow + 1} строка");
