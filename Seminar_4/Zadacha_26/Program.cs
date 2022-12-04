/*
Задача №26: Напишите программу, которая принимает на вход число и выдает количество цифр в числе
456 -> 3
78 -> 2
89126 -> 5
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
int GetLength (int A)
{
    int count = 0; // кол-во цифр в числе
    while (A > 0)
    {
        A = A / 10;
        count++;
    }
    return count;
}
int A = GetNumber("Введите число: ");
int count = GetLength(A);
Console.WriteLine($"Количество цифр в числе {A} = {count}");