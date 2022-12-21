/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
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

string GetValues(int n, int m)
{
    if (n == m)
    {
        return n.ToString();
    }
    return GetValues(n-1, m) + $", {n}";
}

int M = GetNumber("Введите число M больше 1");
int N = GetNumber("Введите число больше M");

GetValues(N, M);
Console.WriteLine (GetValues(N, M));