// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

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

//int[,] InitMatrix()
//{
  //  int[,] matrix = new int[3,4];
   // for (int i = 0; i < matrix.GetLength(0); i++)
   // {
   //     for (int j = 0; j < matrix.GetLength(1); j++)
   //     {
    //        matrix[i,j] = i+j;
  //      }
  //  }
 //   return matrix;
//}


int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    return result;
}

void printElement (int[,] matrix)
{
    int i = GetNumber("Введите строку: ");
    int j = GetNumber("Введите столбец: ");
    if (i>2 || j>3 || i<0 || j<0)
    {
        Console.WriteLine ($"Такого элемента нет");
    }
    else
    {
        Console.WriteLine($"{matrix[i,j]}");
    }
        
}

int[,] matrix = InitMatrix();
PrintMatrix(matrix);
printElement (matrix);