// Сгенерировать случайный массив со случайными числами, вывести его на экран,
// оформить в виде функций
Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] FillArray(int numLine, int NumColumns, int minRand, int maxRand)
{
    int[,] matrix = new int[numLine, NumColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)     // Строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // Столбец
        {
            matrix[i,j] = new Random().Next(minRand, maxRand);
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

int numLine = Prompt("Введите количество строк массива: ");
int NumColumns = Prompt("Введите количество столбцов массива: ");
int minRand = Prompt("Введите нижнюю границу диапазона: ");
int maxRand = Prompt("Введите верхнюю границу диапазона: ");
int[,] matrix = FillArray(numLine, NumColumns, minRand, maxRand);
PrintArray(matrix);
