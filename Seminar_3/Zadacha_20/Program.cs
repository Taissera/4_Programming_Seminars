/*
Задача №20. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
// Вычисляется по формуле: AB = √(xb - xa)2 + (yb - ya)2
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
int x1 = GetNumber("ввод x1" );
int x2 = GetNumber("ввод x2" );
int y1 = GetNumber("ввод y1" );
int y2 = GetNumber("ввод y2" );
double sum1 = Math.Pow((x2 - x1), 2);
double sum2 = Math.Pow((y2 - y1), 2);
double result = Math.Sqrt(sum1 + sum2);
Console.WriteLine(result);
