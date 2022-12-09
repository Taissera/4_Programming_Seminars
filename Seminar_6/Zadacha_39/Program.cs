/*
Задача №39: Напишите программу, которая перевернёт одномерный массив
(последний элемент будет на первом месте, а первый - на последней и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

/*
    1. метод, который будет вызыввать заполненный массив случайными числами
    2. метод, который будет печатать массив
    3. получение числа с консоли, для того, чтобы задать размерность массива
    4. метод, который будет переворачивать массив
*/

// метод, который будет выдавать заполненный массив случайными числами
int[] InitArray (int dimension)
{
    int[] array = new int [dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(1,9);
    }
    return array;
}

// метод, который будет печатать массив
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// получение числа с консоли, для того, чтобы задать размерность массива
int GetNumberFromConsole (string message)
{
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
    {
        Console.WriteLine (message);
        if (int.TryParse(Console.ReadLine(), out result))
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

// метод, который будет переворачивать массив
int [] ReverseArray (int [] array)
{
    int [] result = new int [array.Length];
    int count = 0;
    for (int i = array.Length - 1; i >= 0; i--)
    {
        result [count] = array [i];
        count++;
    }
    return result;
}

int dimension = GetNumberFromConsole ("Введите размерность массива");
int [] startArray = InitArray (dimension);
PrintArray(startArray);
int [] resultArray = ReverseArray (startArray);
PrintArray(resultArray);