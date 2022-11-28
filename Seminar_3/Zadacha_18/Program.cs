/*
Задача №18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/
//Получение номера четверти.
int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;
    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0 && result <= 4)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Введите корректное число от 1 до 4!");
        }
    }
    return result;
}
//получение возможный величин четверти (x, y).
string GetQuarter(int number)
{
    if(number == 1)
        return "Возможный диапазон X:(от 0 до +бесконечность), Y:(от 0 до +бесконечность).";
    else if(number == 2)
        return "Возможный диапазон X:(от 0 до -бесконечность), Y:(от 0 до +бесконечность).";
    else if(number == 3)
        return "Возможный диапазон X:(от 0 до -бесконечность), Y:(от 0 до -бесконечность).";
    else
        return "Возможный диапазон X:(от 0 до +бесконечность), Y:(от 0 до -бесконечность).";
}
int number = GetNumber("Введите число четверти (от 1 до 4):");
string quarter = GetQuarter(number);
Console.WriteLine($"Для четвери {number}: {quarter}");


