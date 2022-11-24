/*
Задача: Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12 -> 2
85 -> 8
*/

Random rnd = new Random();
int number = rnd.Next(10, 100); // [10, 100)
int firstDigit = number / 10;
int secondDigit = number % 10;

Console.WriteLine($"Рандомное число: {number}");

if (firstDigit > secondDigit)
    Console.WriteLine($"Цифра {firstDigit} больше чем {secondDigit}");
else
    if (secondDigit > firstDigit)
    Console.WriteLine($"Цифра {secondDigit} больше чем {firstDigit}");
else
    Console.WriteLine($"Цифры равны");