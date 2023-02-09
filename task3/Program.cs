// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int NaturalNumberInput(string text)
{
    int number;
    Console.WriteLine(text);
    while (true)
    {
        string? str = Console.ReadLine();
        if (int.TryParse(str, out number) && number > 0)
        {
            break;
        }
        else
            System.Console.WriteLine("Введено не натуральное число. Попробуйте снова: ");
    }

    return number;
}

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
            summ += mass[i, j];
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

int[,] MatrixProdact(int[,] matr1, int[,] matr2)
{
    int[,] matr3 = new int[matr1.GetLength(0), matr2.GetLength(1)];

    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                matr3[i,j] += matr1[i,k] * matr2[k,j];
            }
        }
        
    }
    return matr3;
}

int l = NaturalNumberInput("Введите количество строк матрицы А:");
int m = NaturalNumberInput("Введите количество столбцов матрицы А и строк матрицы В:");
int n = NaturalNumberInput("Введите количество столбцов матрицы В:");
Console.WriteLine();
int[,] matrA = MatrixGeneration(l, m);
int[,] matrB = MatrixGeneration(m, n);
MatrixDisplay(matrA);
Console.WriteLine();
MatrixDisplay(matrB);
Console.WriteLine();
int[,] matrC = MatrixProdact(matrA, matrB);
MatrixDisplay(matrC);