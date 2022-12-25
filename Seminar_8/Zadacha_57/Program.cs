/*
Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
*/

int[] array = new int[] { 1, 9, 9, 0, 2, 8, 0, 9 };
Dictionary<int, int> dic = new Dictionary<int, int>();
for (int i = 0; i < array.Length; i++)
{
    if (dic.ContainsKey(array[i]))
        dic[array[i]] = dic[array[i]] + 1;
    else
        dic.Add(array[i], 1);
}
foreach (var item in dic.OrderBy(x => x.Key))
{
    Console.WriteLine($"{item.Key} встречается {item.Value}");
}