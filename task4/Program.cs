// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void MatrixDisplay(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k})\t");
            }
            Console.WriteLine();
        }

    }
}

int[] NonRepeatGeneration(int[,,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(10, 100);
        for (int j = 0; j < i; j++)
        {
            if (array[i] == array[j])
                i--;
        }
    }
    return array;
}

int[,,] MatrixGeneration(int n, int m, int l)
{
    int[,,] matrix = new int[n, m, l];
    int[] nonRepeatRandArray = NonRepeatGeneration(matrix);
    int count = 0;
    for (int z = 0; z < matrix.GetLength(0); z++)
    {
        for (int x = 0; x < matrix.GetLength(1); x++)
        {
            for (int y = 0; y < matrix.GetLength(2); y++)
            {
                matrix[z, x, y] = nonRepeatRandArray[count];
                count++;
            }
        }
    }
    return matrix;
}

int[,,] myMatrix = MatrixGeneration(3,3,3);
MatrixDisplay(myMatrix);
