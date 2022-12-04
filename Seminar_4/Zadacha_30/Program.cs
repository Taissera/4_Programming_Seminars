/*
Задача №30: Напишите программу, которая выводит массив из 8 элементов, заполненный 0 (нулями) и 1 (единицами) в случайном порядке
*/


/*
int[] array = new int [8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,2);  // это плохой вариант, т.к. при большей длине массива сильно грузит память
    Console.Write($"{array[i]} ");
}
*/

// Более верный вариант решения
int[] array = new int [8];
Random rnd = new Random();
for (long i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,2);
    Console.Write($"{array[i]} ");
}

// как ещё можно вывести массив
// Console.WriteLine(array); // плохой вариант, т.к. к выведенному значению припишется "System.Int32[]". Пример: 0 0 0 0 0 1 0 0 System.Int32[]
// лучше использовать структуру через string и абстракции
Console.WriteLine();
Console.WriteLine(string.Join(",", array));
// это также позволяет разделить запятыми выходящие значения и не ставится запятая после последнего