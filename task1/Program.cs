// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] MatrixGeneration(int n, int m)
{
    Random rand = new Random();
    int[,] mass = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mass[i, j] = rand.Next(1, 10);
        }
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

void MatrixOrder(int[,] matr)
{
    int[] array = new int[matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j != matr.GetLength(1); j++)
        {
            array[j] = matr[i,j];
        }
        Array.Sort(array);
        Array.Reverse(array);
        for (int k = 0; k < array.Length; k++)
        {
            matr[i,k] = array[k];
        }
    }
}

int[,] matrix = MatrixGeneration(4, 3);
MatrixDisplay(matrix);
MatrixOrder(matrix);
System.Console.WriteLine();
MatrixDisplay(matrix);