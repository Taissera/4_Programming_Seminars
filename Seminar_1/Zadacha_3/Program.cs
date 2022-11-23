/* Задача №3.
Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/
Console.WriteLine("Введите номер дня недели:");
string? number1Str = Console.ReadLine();
int number1 = Convert.ToInt32(number1Str);

if(number1 == 1)
{
    Console.WriteLine("Понедельник");
}
if(number1 == 2)
{
    Console.WriteLine("Вторник");
}
if(number1 == 3)
{
    Console.WriteLine("Среда");
}
if(number1 == 4)
{
    Console.WriteLine("Четверг");
}
if(number1 == 5)
{
    Console.WriteLine("Пятница");
}
if(number1 == 6)
{
    Console.WriteLine("Суббота");
}
if(number1 == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Ввели число не от 1 до 7");
}