// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] InitMatrix()
{
    int[,] matrix = new int[3,4];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void getMean (int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {   
        double mean = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            mean=mean+matrix[i,j];
        }
        Console.WriteLine($"среднее арифметическое {j} столбца: {mean/matrix.GetLength(0)}");
    }
   
}
int[,] matrix = InitMatrix();
PrintMatrix(matrix);
getMean (matrix);