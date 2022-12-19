/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

// функция ввода числа
// функция задачи рандомного массива
// функция печати массива
// функция замены элементов

// функция ввода числа
int GetNumber(string text)
{
    int result = 0;
    Console.WriteLine(text);
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
    }
    return result;
}

// функция задачи рандомного массива
int[,] GetArray(int m, int n)
{
    int [,] array = new int [m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0,11);
        }
    }
    return array;
}

// функция печати массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

// функция замены элементов
void GetNewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                array[i,j] = array[i,j] * array[i,j];
            }
        }
    }
}

int m = GetNumber("Введите m");
int n = GetNumber("Введите n");

int [,] array = GetArray(m, n);
PrintArray(array);
GetNewArray(array);

Console.WriteLine();
PrintArray(array);