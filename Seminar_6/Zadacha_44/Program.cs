/*
Задача №44: Не используя рекурсию, выведите первые N числа Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

// получение числа с консоли, для того, чтобы задать размерность массива
int GetNumberFromConsole (string message)
{
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
    {
        Console.WriteLine (message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine ("Ввели не число. Введите число");
        }
    }
    return result;
}

// метод, который будет печатать массив
void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// 
int [] NumberFibonachi (int [] array, int num)
{
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}

int [] CheckArray (int [] array2, int num)
{
    if (num == 1)
    {
        array2[0] = 0;
        return array2;
    }
    else if (num == 2)
    {
        array2[0] = 0;
        array2[1] = 1;
        return array2;
    }
    else
    {
        array2 = NumberFibonachi (array2, num);
        return array2;
    }
}
int num = GetNumberFromConsole ("Введите число");
int [] arr = new int [num];
arr = CheckArray (arr, num);
PrintArray(arr);