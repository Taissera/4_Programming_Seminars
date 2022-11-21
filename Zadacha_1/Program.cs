<<<<<<< HEAD
﻿/* Задача №1.
Напишите программу, которая на вход принимает два числа и проверяет является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3, b = 9 -> нет
*/

=======
﻿/* Напишите программу, которая на вход принимает число и выдает его квадрат (число, умноженное на само себя).

Например:
4 -> 16
-3 -> 9
-7 -> 49

то, что мы вводим с консоли, всегда будет тип string
234 - "234"
*/

// Ввод с консоли это всегда тип string
//string numberStr = Console.ReadLine();
// конвертируем 
//int number = int.Parse(numberStr);

// либо используем Convert
//string numberStr = Console.ReadLine();
//int number = Convert.ToInt32(numberStr);

// Int - это Int32 - числа от -2147483647 до 2147483647
// long, Int64 - числа от -9223372036854775807 до 9223372036854775807

/*
Console.WriteLine("Введите число");
string? numberStr = Console.ReadLine();
*/
// ?? - проверка на ввод NULL 
/* 
Срока ниже 
string numberStr = Console.ReadLine() ?? string.Empty;
равна тому, что ниже
string t = Console.ReadLine();
if t == null)
{
    t = "";
}

string numberStr = Console.ReadLine() ?? string.Empty;
знак ?? проверяет, что если вот эта часть "Console.ReadLine()" равна NULL, то берём вот это значение "string.Empty"
если часть "Console.ReadLine()" не равна NULL, то берём значение из "string numberStr"

В C# есть два типа данных: ссылочные (типа string, классы) и значимые (типа int, структура, double, date/time, boolean и т.д.).
Если мы объявим значимый тип int и ничего не присвоим (int number), то это значение number будет равно 0
Если мы объявим ссылочный тип и ничего не присвоим, то значение будет NULL
И зачем-то сделали такую штуку, потому что ссылочные типы и так могут принимать в себя NULL. 
Значимые типы не могут принимать в себя NULL
*/


/*
int number = Convert.ToInt32(numberStr);
int result = number * number;
Console.WriteLine($"Квадрат числа {number} = {result}");
*/
//Console.WriteLine("Квадрат числа " + number + "=" + result);
//Console.WriteLine("Квадрат числа {0} = {1}", number, result);


/*
Console.WriteLine("Введите число");
string? numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
int result = number * number;
Console.WriteLine($"Квадрат числа {number} = {result}");
*/


// конструкцию выше можно написать короче
//Console.WriteLine("Введите число");
//Console.WriteLine($"Квадрат числа {Math.Pow(int.Parse(Console.ReadLine()),2)}");
// у меня не вывелось введённое число

/* Задача №1.
Напишите программу, которая на вход принимает два числа и проверяет является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3, b = 9 -> нет
*/

>>>>>>> parent of fed93cd (Zadacha, Zadacha 1, Zadacha 3, Zadacha 5)
Console.WriteLine("Введите число #1:");
string? number1Str = Console.ReadLine();
int number1 = Convert.ToInt32(number1Str);

Console.WriteLine("Введите число #2:");
string? number2Str = Console.ReadLine();
int number2 = Convert.ToInt32(number2Str);

if(number1/number2 == number2)
{
    Console.WriteLine("Является.");
}
else
{
    Console.WriteLine("Не является.");
<<<<<<< HEAD
}
=======
}
>>>>>>> parent of fed93cd (Zadacha, Zadacha 1, Zadacha 3, Zadacha 5)
