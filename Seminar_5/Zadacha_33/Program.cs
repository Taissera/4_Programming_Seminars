/*
Задача №33: Массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве
*/

// инициализирует новый массив
int[] InitAray (int length)
{
    int[] array = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-9,10);
    }
    return array;
}

// печатает массив на экран
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Вводим число в консоли. Ищем введённое число в массиве
bool IsExist (int [] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number) return true;
    }
    return false;
}

int [] array = InitAray(5);
PrintArray(array);

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string otvet;
bool result = IsExist(array,number);
if (result == true)
{
    otvet = "есть число";
}
else
{
    otvet = "нет числа";
}

Console.WriteLine($"В массиве [{string.Join(",", array)}] {otvet} {number}");

