/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result > 1) break;
        else Console.WriteLine("Ввели не число");
    }
    return result;
}

int Sum(int number)
{
    int result = 0;
    if (number < 10)
    {
        result = number;
    }
    else
    {
        result = Sum(number / 10) + number % 10;
    }
    return result;
}

int number = GetNumber("Введите число");
int summ = Sum(number);
Console.WriteLine($"{summ}");
