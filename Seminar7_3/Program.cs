// Задайте двумерный массив. Введите элемент и найдите первое его вхождение,
// Выведите позиции по горзонтали и вертикали, или напишите,
// что такого элемента нет. Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1,4]
// Введенный элемент 6, результат: такого элемента нет.

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

void FindItem(int[,] myArray, int item)
{
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        if (item == myArray[i,j])
        {
            Console.WriteLine($"Введенный элемент {item}, результат: [{i+1}, {j+1}]");
            return;
        }
    }
}
Console.WriteLine($"Введенный элемент {item}, результат: такого элемента нет");
}

int[,] myArray = FillArray(4, 3);
PrintArray(myArray);
Console.WriteLine("Введите элемент: ");
int item = int.Parse(Console.ReadLine());
FindItem(myArray, item);
