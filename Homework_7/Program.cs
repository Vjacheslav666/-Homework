Console.WriteLine("Домашняя работа 7 семинара!");
Console.WriteLine("Тут находятся домашние задания под номером 47, 50, 52.");
Console.Write("Введите номер домашнего задания: ");
int task = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

switch(task)
{
    case 47:
        Console.WriteLine("Задача 47:");
        Console.WriteLine("Задайте двумерный массив размером m на n, заполненный случайными вещественными числами.");
        int m = ReadInt("Введите число m: ");
        int n = ReadInt("Введите число n: ");
        double[,] numbers47 = new double[m, n + 1];
        TaskNumber47(numbers47);
        break;
    case 50:
        Console.WriteLine("Задача 50:");
        Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
        int line50 = ReadInt("Введите индекс строки: ");
        int post50 = ReadInt("Введите индекс столбца: ");
        int[,] numbers50 = new int[10, 10];
        TaskNumber50(numbers50);

        if (line50 < numbers50.GetLength(0) && post50 < numbers50.GetLength(1)) 
        Console.WriteLine(numbers50[line50, post50]);

        else 
        Console.WriteLine($"{line50}{post50} -> такого числа в массиве нет");
        break;
    case 52:
        Console.WriteLine("Задача 52:");
        Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
        Random random = new Random();
        int[,] arr52 = new int[10, 10];
        TaskNumber52(arr52);
        break;
}

// Задача 47:
void TaskNumber47(double[,] numbers47)
{
    Console.WriteLine();
    for (int i = 0; i < numbers47.GetLength(0); i++)
    {
        for (int j = 0; j < numbers47.GetLength(1); j++)
        {
            numbers47[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;;
            Console.Write(numbers47[i, j] + "   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


// Задача 50:
void TaskNumber50(int[,] array50)
{
    Console.WriteLine();
    for (int i = 0; i < array50.GetLength(0); i++)
    {
        for (int j = 0; j < array50.GetLength(1); j++)
        {
            array50[i, j] = new Random().Next(1, 10);
            Console.Write(array50[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Задача 52:
void TaskNumber52(int[,] arr52)
{
    for (int i52 = 0; i52 < arr52.GetLength(0); i52++)
    {
        for (int j52 = 0; j52 < arr52.GetLength(1); j52++)
        {
            arr52[i52, j52] = new Random().Next(1, 10);
            Console.Write(arr52[i52, j52] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("---------------------------");
    Console.WriteLine(arr52.GetLength(0));
    for (int j52 = 0; j52 < arr52.GetLength(1); j52++)
    {
        double sum52 = 0;
        for (int i52 = 0; i52 < arr52.GetLength(0); i52++)
        {
            sum52 += arr52[i52, j52];
        }
        Console.Write($"{ sum52 / arr52.GetLength(0) + "   "} ");
    }
    Console.ReadLine();
}

// Вводная функция:
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}