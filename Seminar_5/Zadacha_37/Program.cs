/*
Задача №37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в нов
[1 2 3 4 5] -> 5 8 3
[6 7 8 3 6] -> 36 21
*/

// инициализирует новый массив в значении -9 до 10
int[] GetArray (int length)
{
    int[] array = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-9,10);
    }
    return array;
}

// Вариант на семинаре

int [] NewArray (int [] array)
{
    int [] arr;
    int len = 0;
    if (array.Length%2 == 0)
    {
        len = array.Length/2;
        arr = new int [len];
        for (int i = 0; i < len; i++)
        {
        arr[i] = array[i] * array[array.Length - i - 1];
        }
        return arr;   
    }
    else
    {
        len = array.Length/2 + 1;
        arr = new int [len];
        //arr [len-1] = array [len];
        for (int i = 0; i < array.Length/2 + 1; i++) //array.Length/2 //len-1 // len
        {
        arr[i] = array[i] * array[array.Length - i - 1];
        /*if (i == array.Length - 1 -i)
        {
            arr[i] = array[i];
        }*/
        }
        return arr;
    }
}


// вариант переделанный
/*
int [] NewArray (int [] arr)
{
    int len = 0;
    if (arr.Length%2 == 0)
    {
        len = arr.Length/2;
    }
    else
    {
        len = arr.Length/2 + 1;
    }
    int [] array = new int [len];
    for (int i = 0; i < len; i++) //array.Length/2
    {
        arr[i] = arr[i] * arr[arr.Length - i - 1];
        if (i == arr.Length - 1 -i) array[i] = array[i]/arr[i];
    }
    return arr;
}
*/

// печатает массив на экран
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива");
int [] array = GetArray(Convert.ToInt32(Console.ReadLine()));
PrintArray(array);
Console.WriteLine();
int [] arr = NewArray(array);
PrintArray(arr);