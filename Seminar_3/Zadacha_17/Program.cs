/*
Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

             |
      2      |       1
             |
-------------------------->
             |
      3      |       4
*/
//функция получения числа с консоли
int GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;


    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result != 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число или 0. Введите корректное число");
        }
    }

    return result;
}
//получение четверти, в которой лежит точка с координатами (x, y)
int GetQuarter(int x, int y)
{
    if(x > 0 && y >0)
        return 1;
    else if(x < 0 && y > 0)
        return 2;
    else if(x < 0 && y < 0)
        return 3;
    else
        return 4;
}
int x = GetNumber("Введите координату Х:");
int y = GetNumber("Введите координату У:");
int quarter = GetQuarter(x, y);
Console.WriteLine($"Точка с координатами ({x}, {y}) лежит в {quarter} четверти.");
