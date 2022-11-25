/*
Задача №12: Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

Console.WriteLine("Введите число #1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число #2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 % number1 == 0)
{
    Console.WriteLine($"Число {number2} кратно числу {number1}");
}
else
{
    int result = number2 % number1;
    Console.WriteLine($"Число {number2} НЕ кратно числу {number1}. Остаток: {result}");
}