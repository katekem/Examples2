// Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1 4 7
// 5 9 2
// 8 4 2
// Сумма элементов главной диагонали: 1 + 9 + 2 = 12
Console.Clear();

int[,] FillArray(int numLine, int NumColumns)
{
    int[,] matrix = new int[numLine, NumColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)     // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // Столбец
        {
            matrix[i, j] = new Random().Next(0,15);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] myArray = FillArray(5, 5);
PrintArray(myArray);
Console.WriteLine(GetSum(myArray));

// int GetSum(int[,] myArray)
// {
// int sum = 0;
// for (int i = 0; i < myArray.GetLength(0); i++)
// {
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//         if (i == j)
//         {
//             sum += myArray[i, j];
//         }
//     }
// }
//     return sum;
// }

int GetSum(int[,] myArray)
{
    int sum = 0;
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        sum += myArray[i, i];
    }
    return sum;
}
