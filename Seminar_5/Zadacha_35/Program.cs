/*
Задача №35: Задайте одномерный массив из 123х случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123х элементов. В своём решении сделайте для 123х.
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

// инициализирует новый массив из 123х чисел от в значении -1000 до 1000
int[] GetArray (int length)
{
    int[] array = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-1000,1001);
    }
    return array;
}

// печатает массив на экран
/*
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
*/

// считает количество элементов массива, значения которых лежат в отрезке [10,99]
int Count (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) count++;
    }
    return count;
}

Console.WriteLine("Введите размер массива");
// int [] array = GetArray(int.Parse(Console.ReadLine()));
// строка выше вызывает warning CS8604. Чтобы этого избежать лучше использовать метод Convert.ToInt32
int [] array = GetArray(Convert.ToInt32(Console.ReadLine()));


Console.WriteLine();
Console.WriteLine($"В массиве [{string.Join(",", array)}] количество элементов, значения которых лежат в отрезке [10,99] равно {Count(array)}");
