/*
Задача №42: Напишите программу, которая будет преобразовывать десятичное число в двоичное
45 -> 101101
3 -> 11
2 -> 10
*/

int GetNumber (string text)
{
    Console.WriteLine(text);
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect)
    {
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

string DecToBin (int decNumber)
{
    string result = string.Empty;
    while (decNumber != 0)
    {
        result = result + decNumber%2;
        decNumber = decNumber/2;
    }
    return result;
}

int decNumber = GetNumber ("Введите число");
Console.Write("-> ");
string result = DecToBin (decNumber);
Console.Write (new string (result.Reverse().ToArray()));