/*
Задача №40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
*/

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
            Console.WriteLine ("Ввели не число. ВВедите число");
        }
    }
    return result;
}

int a = GetNumberFromConsole ("Введите первую сторону треугольника: ");
int b = GetNumberFromConsole ("Введите вторую сторону треугольника: ");
int c = GetNumberFromConsole ("Введите третью сторону треугольника: ");

if ((a + b) > c && (b + c) > a && (a + c) > b)
{
    Console.WriteLine("Треугольник существует: ");
}
else
{
    Console.WriteLine("Треугольник не существует: ");
}