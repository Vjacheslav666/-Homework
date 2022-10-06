// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Clear();
Console.WriteLine("Задача 41:");
Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.WriteLine();
Console.Write("Введите общее число цыфр: ");
int coll41 = Convert.ToInt32(Console.ReadLine());
taskNumber41(coll41);

void taskNumber41(int coll41)
{
    string result41 = string.Empty;
    int[] massive41 = new int[coll41];
    int count41 = 0;
    for(int index41 = 0; index41 < coll41; index41++)
    {
        Console.Write($"Введите {index41 + 1} число: ");
        massive41[index41] = Convert.ToInt32(Console.ReadLine());
        result41 += massive41[index41] + ", ";
        if(massive41[index41] > 0)
        count41++;
    }
    Console.WriteLine();
    Console.WriteLine($"Вы ввели числа: {result41} \nВведено чисел больше 0:  {count41}!");
    Console.WriteLine();
}
