/* 
Задча №28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 (= 1 * 2 * 3 * 4)
5 -> 120 (= 1 * 2 * 3 * 4 * 5)
*/

int GetNumber (string message)
{
    bool isCorrest = false;
    int result = 0;

    while (!isCorrest)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(),out result))
        {
            isCorrest = true;
        }
    else
    {
        Console.WriteLine("Ввели НЕ число");
    }
    }
    return result;
}

int GetProduct (int number)
{
    int prod = 1;
    for (int i = 1; i <= number; i++)
    {
        prod *= i;
    }
    return prod;
}

int number = GetNumber("Введите число");
int product = GetProduct (number);

Console.WriteLine($"Произведение чисел от 1 до {number} = {product}");