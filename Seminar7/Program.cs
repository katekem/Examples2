// Задайте двумерный массив размера m на n, каждый элемент в массиве находится
// по формуле Amn = m + n. Выведите полученный массив на экран.
Console.Clear();
int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] FillArray(int numLine, int NumColumns)
{
    int[,] matrix = new int[numLine, NumColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)     // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // Столбец
        {
            matrix[i,j] = i + j;
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
        Console.Write($"{matrix[i,j]}\t");
     }   
     Console.WriteLine();
    }
}

int[,] matrix = FillArray(
    Prompt("Введите количество строк: "),
    Prompt("Введите количество столбцов: "));
PrintArray(matrix);