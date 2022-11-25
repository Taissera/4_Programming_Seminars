/*
Задача №14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/

//int number = new Random().Next();
//Console.WriteLine($"Рандомное число: {number}");

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 ==0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}