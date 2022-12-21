/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

int GetNumber(string text)
{
    Console.WriteLine(text);
    int num = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out num)) break;
        else Console.WriteLine("Ввели не число");
    }
    return num;
}

int[,] GetMatrix(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}, ");
        }
        Console.WriteLine();
    }
}

int[,] GetMatrixRepl(int[,] matrix)
{
    int[,] matrixResult = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            matrixResult[i, j] = matrix[j, i];
        }
    }
    return matrixResult;
}

int m = GetNumber("Введиете количество строк");
int n = GetNumber("Введите количество столбцов");
int[,] matrix = GetMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
GetMatrixRepl(matrix);
PrintMatrix(GetMatrixRepl(matrix));