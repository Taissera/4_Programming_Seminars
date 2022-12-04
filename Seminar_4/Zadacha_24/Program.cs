/*
Задача №24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28 (= 1 + 2 + 3 + 4 + 5 + 6 + 7)
4 -> 10 (= 1 + 2 + 3 + 4)
8 -> 36 (= 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8)
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

int GetSumm (int number)
{
    int summ = 0;
    for (int i = 1; i <= number; i++)
    {
        summ += i;
    }
    return summ;
}

int number = GetNumber("Введите число");
int summ = GetSumm(number);

Console.WriteLine($"Сумма чисел от 1 до {number} = {summ}");