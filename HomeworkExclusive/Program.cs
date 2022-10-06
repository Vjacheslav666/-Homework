Console.Clear();
Console.WriteLine("Вся домашняя работа находится здесь!");
Console.WriteLine("Работа написана Вячеславом.");
Console.WriteLine("Введите номер домашнего задания от 1 до 9!");
Console.Write("Введите номер домашнего задания: ");
int Homework = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

while(Homework == 1)
{
    Console.WriteLine("Вы перешли на домашнее задание первого семинара!");
    Console.WriteLine("Номера домашних заданий: 2, 4, 5, 6, 7, 8.");
    Console.Write("Введите номер задания: ");
    int task1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch(task1)
    {
        case 2:
            Console.WriteLine("Задача 2:");
            Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
            Console.Write("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            string result2X = TaskNumber2(num1, num2);

            Console.WriteLine(result2X);
            Console.WriteLine();
            break;
        case 4:
            Console.WriteLine("Задача 4:");
            Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
            Console.Write("Введите первое число: ");
            int x1task4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int x2task4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int x3task4 = Convert.ToInt32(Console.ReadLine());

            string result4X = TaskNumber4(x1task4, x2task4, x3task4);

            Console.WriteLine(result4X);
            Console.WriteLine();
            break;
        case 5:
            Console.WriteLine("Задача 5:");
            Console.WriteLine("Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.");
            Console.Write("Введите число N: ");
            int task5num = Convert.ToInt32(Console.ReadLine());
            
            string result5X = TaskNumber5(task5num);

            Console.WriteLine(result5X);
            break;
        case 6:
            Console.WriteLine("Задача 6:");
            Console.WriteLine("Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
            Console.Write("Введите число: ");
            int task6num = Convert.ToInt32(Console.ReadLine());

            string result6X = TaskNumber6(task6num);

            Console.WriteLine(result6X);
            Console.WriteLine();
            break;
        case 7:
            Console.WriteLine("Задача 7:");
            Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.");
            Console.Write("Введите трёхзначное число: ");
            int task7num = Convert.ToInt32(Console.ReadLine());

            string result7X = TaskNumber7(task7num);

            Console.WriteLine(result7X);
            Console.WriteLine();
            break;
        case 8:
            Console.WriteLine("Задача 8:");
            Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
            Console.Write("Введите число N: ");
            int task8num = Convert.ToInt32(Console.ReadLine());
            int [] mass8 = new int[task8num];
            TaskNumber8(mass8);
            break;
    }
}

while(Homework == 2)
{
    Console.WriteLine("Вы перешли на домашнее задание второго семинара!");
    Console.WriteLine("Номера домашних заданий: 10, 13, 15.");
    Console.Write("Введите номер задания: ");
    int task2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch(task2)
    {
        case 10:
            Console.WriteLine("Задача 10:");
            Console.WriteLine("Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
            Console.Write("Введите трёхзначное число: ");
            int task10X = Convert.ToInt32(Console.ReadLine());
            
            string result10X = TaskNumber10(task10X);

            Console.WriteLine(result10X);
            Console.WriteLine();
            break;
        case 13:
            Console.WriteLine("Задача 13:");
            Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
            Console.Write("Введите число: ");
            int task13X = Convert.ToInt32(Console.ReadLine());

            string result13X = TaskNumber13(task13X);

            Console.WriteLine(result13X);
            Console.WriteLine();
            break;
        case 15:
            Console.WriteLine("Задача 15:");
            Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
            Console.Write("Введите число от 1 до 7: ");
            int task15X = Convert.ToInt32(Console.ReadLine());

            string result15X = TaskNumber15(task15X);

            Console.WriteLine(result15X);
            Console.WriteLine();
            break;
    }
}

while(Homework == 3)
{
    Console.WriteLine("Вы перешли на домашнее задание третьего семинара!");
    Console.WriteLine("Номера домашних заданий: 19, 21, 23.");
    Console.Write("Введите номер задания: ");
    int task3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch(task3)
    {
        case 19:
            Console.WriteLine("Задача 19:");
            Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
            Console.Write("Введите пятизначное число: ");
            int task19X = Convert.ToInt32(Console.ReadLine());

            string result19X = TaskNumber19(task19X);

            Console.WriteLine(result19X);
            Console.WriteLine();
            break;
        case 21:
            Console.WriteLine("Задача 21:");
            Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
            Console.Write("Введите координату x точки А: ");
            int korx1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y точки А: ");
            int kory1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату z точки А: ");
            int korz1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату x точки B: ");
            int korx2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y точки B: ");
            int kory2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату z точки B: ");
            int korz2 = Convert.ToInt32(Console.ReadLine());

            double result21X = Math.Round (TaskNumber21(korx1, korx2, kory1, kory2, korz1, korz2), 2);

            Console.WriteLine($"Длина отрезка  {result21X}");
            Console.WriteLine();
            break;
        case 23:
            Console.WriteLine("Задача 23:");
            Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
            Console.Write("Введите число: ");
            int task23X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Таблица кубов числа {task23X}:");
            
            string result23X = TaskNumber23(task23X);

            Console.WriteLine(result23X);
            Console.WriteLine();
            break;
    }
}

while(Homework == 4)
{
    Console.WriteLine("Вы перешли на домашнее задание четвертого семинара!");
    Console.WriteLine("Номера домашних заданий: 25, 27, 29.");
    Console.Write("Введите номер задания: ");
    int task4 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch(task4)
    {
        case 25:
            Console.WriteLine("Задача 25:");
            Console.WriteLine("Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
            Console.Write("Введите число A: ");
            int Atask25 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int Btask25 = Convert.ToInt32(Console.ReadLine());

            string result25X = TaskNumber25(Atask25, Btask25);

            Console.WriteLine(result25X);
            Console.WriteLine();
            break;
        case 27:
            Console.WriteLine("Задача 27:");
            Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
            Console.Write("Введите число: ");
            int n27 = Convert.ToInt32(Console.ReadLine());

            string result27X = TaskNumber27(n27);

            Console.WriteLine(result27X);
            Console.WriteLine();
            break;
        case 29:
            Console.WriteLine("Задача 29:");
            Console.WriteLine("Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
            int [] n29 = new int[8];
            TaskNumber29(n29);
            break;
    }
}

while(Homework == 5)
{
    Console.WriteLine("Вы перешли на домашнее задание пятого семинара!");
    Console.WriteLine("Номера домашних заданий: 34, 36, 38.");
    Console.Write("Введите номер задания: ");
    int task5 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch(task5)
    {
        case 34:
            Console.WriteLine("Задача 34:");
            Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
            Console.Write("Введите размер массива:  ");
            int coll34 = Convert.ToInt32(Console.ReadLine());
            int[] mass34 = new int[coll34];
            Console.WriteLine();
            Console.WriteLine("массив: ");
            TaskNumber34(mass34);
            Console.WriteLine();
            break;
        case 36:
            Console.WriteLine("Задача 36:");
            Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
            Console.Write("Введите размер массива: ");
            int coll36 = Convert.ToInt32(Console.ReadLine());
            int[] numbers36 = new int[coll36];
            Console.WriteLine("Вот наш массив: ");
            TaskNumber36(numbers36);
            break;
        case 38:
            Console.WriteLine("Задача 38:");
            Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
            Console.Write("Введите размер массива: ");
            int coll38 = Convert.ToInt32(Console.ReadLine());
            double[] mass38 = new double[coll38];
            Console.WriteLine("Вот наш массив: ");
            TaskNumber38(mass38);
            break;
    }
}

while(Homework == 6)
{
    Console.WriteLine("Вы перешли на домашнее задание шестого семинара!");
    Console.WriteLine("Номера домашних заданий: 41, 43.");
    Console.Write("Введите номер задания: ");
    int task6 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch(task6)
    {
        case 41:
            Console.WriteLine("Задача 41:");
            Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
            Console.WriteLine();
            Console.Write("Введите общее число цыфр: ");
            int coll41 = Convert.ToInt32(Console.ReadLine());
            taskNumber41(coll41);
            break;
        case 43:
            Console.WriteLine("Задача 43:");
            Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых, \nзаданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
            Console.WriteLine();
            Console.WriteLine("Введите значения первой прямой!");
            Console.Write("Введите точку b1; ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите точку k1; ");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите значения второй прямой!");
            Console.Write("Введите точку b2; ");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите точку k2; ");
            int k2 = Convert.ToInt32(Console.ReadLine());
            taskNumber43(b1, k1, b2, k2);
            break;
    }
}

while(Homework == 7)
{
    Console.WriteLine("Вы перешли на домашнее задание седьмого семинара!");
    Console.WriteLine("Номера домашних заданий: 47, 50, 52.");
    Console.Write("Введите номер задания: ");
    int task7 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch(task7)
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
}

while(Homework == 8)
{
    Console.WriteLine("Домашняя работа восьмого семинара!");
    Console.WriteLine("Тут находятся домашние задания под номером 54, 56, 58, 60, 62.");
    int task8 = ReadInt("Введите номер домашнего задания: ");
    Console.WriteLine();

    switch(task8)
    {
        case 54:
            Console.WriteLine("Задача 54:");
            Console.WriteLine("Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
            int m54 = ReadInt("Введите колличество строк в массиве: ");
            int n54 = ReadInt("Введите колличество столбов в массиве: ");
            int[,] numbers54 = new int[m54, n54];
            TaskNumber54(numbers54);
            Console.WriteLine();
            Console.WriteLine("Массив до изменения: ");
            PrintMassive54(numbers54);
            ReversMassive54(numbers54);
            Console.WriteLine();
            Console.WriteLine("Массив с упорядоченными значениями: ");
            PrintMassive54(numbers54);
            Console.WriteLine();
            break;
        case 56:
            Console.WriteLine("Задача 56:");
            Console.WriteLine("Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
            Console.WriteLine();
            int count56 = ReadInt("Введите размер массива: ");
            int[,] numbers56 = new int[count56, count56];
            RandomMassive56(numbers56);
            SunNumbers56(numbers56);
            break;
        case 58:
            Console.WriteLine("Задача 58:");
            Console.WriteLine("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
            Console.WriteLine();
            int size = ReadInt("Размеры матриц: ");
            Console.WriteLine();
            int[,] matrixA = new int[size, size];
            int[,] matrixB = new int[size, size];
            int[,] matrixC = new int[size, size];
            TaskMatrix58(matrixA);
            TaskMatrix58(matrixB);
            CountingMassive58(matrixA, matrixB, matrixC, size);
            Console.WriteLine("Матрица - А:");
            PrintNumber58(matrixA);
            Console.WriteLine();
            Console.WriteLine("Матрица - В:");
            PrintNumber58(matrixB);
            Console.WriteLine();
            Console.WriteLine("Произведение матриц А*В:");
            PrintNumber58(matrixC);
            Console.WriteLine();
            break;
        case 60:
            Console.WriteLine("Задача 60:");
            Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
            int num1 = ReadInt("Введите размерность 1: ");
            int num2 = ReadInt("Введите размерность 2: ");
            int num3 = ReadInt("Введите размерность 3: ");
            int countNums = 90;
            Console.WriteLine();
            if (num1 * num2 * num3 > countNums)
            {
                Console.Write("Массив слишком большой");
                return;
            }
            Console.WriteLine();
            Create3DMassive(num1, num2, num3, countNums);
            break;
        case 62:
            Console.WriteLine("Задача 62:");
            Console.WriteLine("Напишите программу, которая заполнит спирально массив.");
            Console.WriteLine();
            int number62 = ReadInt("Введите размер массива: ");
            int[,] nums = new int[number62, number62];
            Console.WriteLine();
            TaskNumber62(number62, nums);
            PrintNumber62(nums);
            Console.WriteLine();
            break;
    }
}

while(Homework == 9)
{
    Console.WriteLine("Домашняя работа девятого семинара!");
    Console.WriteLine("Тут находятся домашние задания под номером 64, 66, 68.");
    int task9 = ReadInt("Введите номер домашнего задания: ");
    Console.WriteLine();

    switch(task9)
    {
        case 64:
            Console.WriteLine("Задача 64:");
            Console.WriteLine("Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
            int m64 = ReadInt("Введите число M: ");
            int n64 = ReadInt("Введите число N: ");
            Console.WriteLine();
            TaskNumber64(m64, n64);
            Console.WriteLine();
            break;
        case 66:
            Console.WriteLine("Задача 66:");
            Console.WriteLine("Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
            int m66 = ReadInt("Введите число M: ");
            int n66 = ReadInt("Введите число N: ");
            Console.WriteLine();
            string result66 = TaskNumber66(m66, n66);
            Console.WriteLine(result66);
            Console.WriteLine();
            break;
        case 68:
            Console.WriteLine("Задача 68:");
            Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N.");
            int m68 = ReadInt("Введите число M: ");
            int n68 = ReadInt("Введите число N: ");
            Console.WriteLine();
            if(n68 < 0 && m68 < 0)
            {
                Console.WriteLine($"Вы ввели отрицательное число M {m68}.");
                Console.WriteLine();
                Console.WriteLine($"Вы ввели отрицательное число N {n68}.");
                Console.WriteLine();
                return;
            }
            else if(m68 < 0)
            {
                Console.WriteLine($"Вы ввели отрицательное число M {m68}.");
                Console.WriteLine();
                return;
            }
            else if(n68 < 0)
            {
                Console.WriteLine($"Вы ввели отрицательное число N {n68}.");
                Console.WriteLine();
                return;
            }
            AkkermanFunction(m68,n68);
            break;
    }
}

// Задачи первого семинара.

// Задача 2:
string TaskNumber2(int num1, int num2)
{
    string result2X = string.Empty;

        if (num1 > num2)
        result2X = "Первое введённое число больше второго!";

        if (num1 < num2)
        result2X = "Второе введённое число больше первого!";

        else if (num1 == num2)
        result2X = "Введенные числа равны!";

        return result2X;
}

// Задача 4:
string TaskNumber4(int x1task4, int x2task4, int x3task4)
{
    string result4X = string.Empty;
    int numx1 = Convert.ToInt32(x1task4);
    int numx2 = Convert.ToInt32(x2task4);
    int numx3 = Convert.ToInt32(x3task4);

    if (numx1 > numx2 && numx1 > numx3)
    result4X = "Первое введенное число больше!";

    else if (numx2 > numx1 && numx2 > numx3)
    result4X = "Второе введенное число больше!";

    else if (numx3 > numx2 && numx3 > numx1)
    result4X = "Третье введенное число больше!";

    else if (numx1 == numx2 && numx2 == numx3)
    result4X = "Введенные числа равны!";

    else if (numx1 == numx2 && numx1 != numx3)
    result4X = "Первое и второе числа равны, но больше третьего!";

    else if (numx2 == numx3 && numx2 != numx1)
    result4X = "Второе и третье числа равны, но больше первого!";

    else if (numx1 == numx3 && numx1 != numx2)
    result4X = "Первое и третье числа равны, но больше второго!";

    return result4X;
}

// Задача 5:
string TaskNumber5(int task5num)
{
    string result5X = "";
    int startN = task5num * -1;
    while (startN <= task5num)
    {
        result5X += startN + " ";
        startN++;
    }
    return result5X;
}

// Задача 6:
string TaskNumber6(int task6num)
{
    string result6X = string.Empty;

    if (task6num % 2 == 0)
    result6X = "Число является чётным!";

    else
    result6X = "Число не является чётным!";

    return result6X;
}

// Задача 7:
string TaskNumber7(int task7num)
{
    string result7X = string.Empty;
    int aTask7 = task7num % 10;
    return result7X = $"Последняя цифра введённого числа равна: {aTask7}";
}

// Задача 8:
void TaskNumber8(int[] mass8)
{
    for(int i8 = 0; i8 < mass8.Length; i8++)
    {
        mass8[i8] = i8 + 1;
        if(mass8[i8] % 2 == 0)
        {
            Console.Write(mass8[i8] + " ");
        }
    }
    Console.WriteLine();
}

// Задачи второго семинара.

// Задача 10:
string TaskNumber10(int task10X)
{
    string result10X = string.Empty;
    int numtask10 = Convert.ToInt32(task10X);

    if(numtask10 >= 100 && numtask10 < 1000)
    {
        int res10 = (numtask10 % 100) / 10;
        result10X = $"Вторая цифра трёхзначного числа равна {res10}";
    }
    return result10X;
}

// Задача 13:
string TaskNumber13(int task13X)
{
    string result13X = string.Empty;
    int numtask13 = Convert.ToInt32(task13X);
    string num13mass = Convert.ToString(numtask13);
    if(numtask13 >= 100)
    return result13X = $"Третья цифра введённого числа: {num13mass[2]}";

    else
    return result13X = "Третьей цифры нет!";
}

// Задача 15:
string TaskNumber15(int task15X)
{
    string result15X = string.Empty;
    int num15task = Convert.ToInt32(task15X);
    if(num15task >= 1 && num15task <=7)
    {
        if(num15task == 6 || num15task == 7)
        result15X = "Ура, выходной!";

        else if(num15task > 0 && num15task < 6)
        result15X = "Этот день рабочий!";
    }

    else if(num15task <= 0 || num15task > 7)
    result15X = "В неделе только 7 дней!";

    return result15X;
}

// Задачи третьего семинара.

// Задача 19:
string TaskNumber19(int task19X)
{
    string result19X = string.Empty;
    int numtask19 = Convert.ToInt32(task19X);
    string num19 = numtask19.ToString();
    if (numtask19 >= 10000 && numtask19 < 100000)
    {
        if(num19[0] == num19[4] && num19[1] == num19[3])
        result19X = $"Введённое число {task19X} является палиндромом!";

        else
        result19X = $"Введённое число {task19X} не является палиндромом!";
    }

    else if ((numtask19 < 10000) || (numtask19 >= 100000))
    result19X = "Вы ввели неправильное число. Введите пожалуйста пятизначное число!";

    return result19X;
}

// Задача 21:
double TaskNumber21(double korx1, double korx2, double kory1, double kory2, double korz1, double korz2)
{
    double result21X = Math.Sqrt(Math.Pow((korx2-korx1), 2) + 
                                Math.Pow((kory2-kory1), 2) + 
                                Math.Pow((korz2-korz1), 2));
    return result21X;
}

// Задача 23:
string TaskNumber23(int task23X)
{
    string result23X = string.Empty;
    int numtask23 = Convert.ToInt32(task23X);
    for(int i23 = 1; i23 <= numtask23; i23++)
    {
        int n23 = i23 * i23 * i23;
        result23X += $"{i23} * {i23} * {i23} = {n23} \n";
    }
    return result23X;
}

// Задачи четвертого семинара.

// Задача 25:
string TaskNumber25(int Atask25, int Btask25)
{
    string result25X = string.Empty;
    int A25 = Convert.ToInt32(Atask25);
    int B25 = Convert.ToInt32(Btask25);
    int num25 = A25;
    for(int i = 1; i < B25; i++)
    {
        num25 = num25 * A25;
        result25X = $"A в степени B равно: {num25}";
    }
    return result25X;
}

// Задача 27:
string TaskNumber27(int n27)
{
    string result27X = string.Empty;
    int nTatk27 = Convert.ToInt32(n27);
    int sum27 = 0;
    while(nTatk27 > 0)
    {
        int nres27 = nTatk27 % 10;
        nTatk27 = nTatk27 / 10;
        sum27 = sum27 + nres27;
    }
    return result27X = $"Сумма всех цифр в числе равна: {sum27}";
}

// Задача 29:
void TaskNumber29(int[] massiw)
{
    int m29 = massiw.Length;
    int i29 = 0;
    Console.Write("[ ");
    while(i29 < m29)
    {
        massiw[i29] = new Random().Next(0, 100);
        Console.Write(massiw[i29] + " ");
        i29++;
    }
    Console.WriteLine("]");
    Console.WriteLine();
}

// Задачи пятого семинара.

// Задача 34:
void TaskNumber34(int[] mass34)
{
    int count34 = 0;
    Console.Write("[ ");
    for (int z34 = 0; z34 < mass34.Length; z34++)
    {
        mass34[z34] = new Random().Next(100,1000);
        if (mass34[z34] % 2 == 0)
        count34++;
        Console.Write(mass34[z34] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Всего {mass34.Length} чисел, {count34} из них чётные");
}

// Задача 36:
void TaskNumber36(int[] numbers36)
{
    Console.Write("[ ");
    for(int i36 = 0; i36 < numbers36.Length; i36++)
    {
        numbers36[i36] = new Random().Next(1,10);
        Console.Write(numbers36[i36] + " ");
    }
    Console.Write("]");
    Console.WriteLine();

    int sum36 = 0;
    for (int z36 = 1; z36 < numbers36.Length; z36+=2)
    sum36 = sum36 + numbers36[z36];

    Console.WriteLine($"всего {numbers36.Length} чисел, сумма элементов на нечётных позициях = {sum36}");
}

// Задача 38:
void TaskNumber38(double[] mass38)
{
    double min38 = Int32.MaxValue;
    double max38 = Int32.MinValue;

    Console.Write("[ ");
    for (int z38 = 0; z38 < mass38.Length; z38++)
    {
        mass38[z38] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        if (mass38[z38] > max38)
        max38 = mass38[z38];
        if (mass38[z38] < min38)
        min38 = mass38[z38];

        Console.Write(mass38[z38] + "   ");
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine($"Всего {mass38.Length} чисел. \nМаксимальное значение = {max38}, \nминимальное значение = {min38}");
    Console.WriteLine($"Разница между максимальным и минимальным значением = {max38 - min38}");
}

// Задачи шестого семинара.

// Задача 41:
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

// Задача 43:
void taskNumber43(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;
    Console.WriteLine($"{y1}, {y2}");
    if(y1 == 0 && y2 == 0)
    Console.WriteLine("Пряпые не пересекаются!");
    Console.WriteLine();
}

// Задачи седьмого семинара.

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

// Задачи восьмого семинара.

// Задача 54:
void TaskNumber54(int[,] numbers54)
{
    for (int i = 0; i < numbers54.GetLength(0); i++)
    {
        for (int j = 0; j < numbers54.GetLength(1); j++)
        {
            numbers54[i, j] = new Random().Next(1, 10);
        }
    }
}

void ReversMassive54(int[,] numbers54)
{
    for (int i = 0; i < numbers54.GetLength(0); i++)
    {
        for (int j = 0; j < numbers54.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < numbers54.GetLength(1) - 1; z++)
            {
                if (numbers54[i, z] < numbers54[i, z + 1]) //для изменения сортировки поменять знак < на >!
                {
                    int temp = 0;
                    temp = numbers54[i, z];
                    numbers54[i, z] = numbers54[i, z + 1];
                    numbers54[i, z + 1] = temp;
                }
            }
        }
    }
}

void PrintMassive54(int[,] numbers54)
{
    for (int i = 0; i < numbers54.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < numbers54.GetLength(1); j++)
        {
            Console.Write(numbers54[i, j] + "   ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// Задача 56:
void RandomMassive56(int[,] numbers56)
{
    for (int i = 0; i < numbers56.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < numbers56.GetLength(1); j++)
        {
            numbers56[i, j] = new Random().Next(0, 10);
            Console.Write(numbers56[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

void SunNumbers56(int[,] numbers56)
{
    int minsum = Int32.MaxValue;
    int indexLine = 0;

    for (int i = 0; i < numbers56.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < numbers56.GetLength(1); j++)
        {
            sum = sum + numbers56[i, j];        
        }
        if (sum < minsum)
        {
            minsum = sum;
            indexLine++;
        }
    }
Console.WriteLine();
Console.WriteLine("Строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));
Console.WriteLine();
}

// Задача 58:
void TaskMatrix58(int[,] Massive)
{
    for (int i = 0; i < Massive.GetLength(0); i++)
    {
        for (int j = 0; j < Massive.GetLength(1); j++)
        {
            Massive[i, j] = new Random().Next(1, 5);
        }
    }
}

void CountingMassive58(int[,] matrixA, int[,] matrixB, int[,] matrixC, int size)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
            }
        }
    }
}

void PrintNumber58(int[,] Massive)
{
    for (int i = 0; i < Massive.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < Massive.GetLength(1); j++)
        {
            Console.Write(Massive[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// Задача 60:
int[,,] Create3DMassive(int num1, int num2, int num3, int countNums)
{
    int[,,] resultNums = new int[num1, num2, num3];
    int[] values = new int[countNums];
    int num = 10;
    for (int i = 0; i < values.Length; i++)
    values[i] = num++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < resultNums.GetLength(0); i++)
    {
        for (int j = 0; j < resultNums.GetLength(1); j++)
        {
            for (int k = 0; k < resultNums.GetLength(2); k++)
            {
                resultNums[i, j, k] = values[valueIndex++];
                Console.WriteLine($"[{i},{j},{k}] - {resultNums[i, j, k]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    return resultNums;
}

// Задача 62:
void TaskNumber62(int number62, int[,] nums)
{
    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= number62 * number62)
    {
        nums[i, j] = num;
        if (i <= j + 1 && i + j < number62 - 1)
            ++j;
        else if (i < j && i + j >= number62 - 1)
            ++i;
        else if (i >= j && i + j > number62 - 1)
            --j;
        else
            --i;
        ++num;
    }
}

void PrintNumber62(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// Задачи девятого семинара.

// Задача 64:
void TaskNumber64(int m64, int n64)
{
    if(m64 < n64)
    {
        for(int i = m64; i <= n64; i++)
        {
            Console.Write($"{i},  ");
        }
    }

    else if(m64 > n64)
    {
        for(int i = m64; i >= n64; i--)
        {
            Console.Write($"{i},  ");
        }
    }

    else if(m64 == n64)
    {
        Console.WriteLine("Введённые числа M и N равны!");
    }
}

// Задача 66:
string TaskNumber66(int m66, int n66)
{
    string result66 = string.Empty;
    int count = 0;
    if(m66 < n66)
    {
        for(int i = m66; i <= n66; i++)
        {
            count = count + i;
            result66 = $"Сумма всех натуральных элементов в промежутке от {m66} до {n66} равна {count}";
        }
        return result66;
    }

    else if(m66 > n66)
    {
        for(int i = m66; i >= n66; i--)
        {
            count = count + i;
            result66 = $"Сумма всех натуральных элементов в промежутке от {m66} до {n66} равна {count}";
        }
        return result66;
    }

    else if(m66 == n66)
    {
        result66 = "Введённые числа M и N равны!";
    }
    return result66;
}

// Задача 68:
void AkkermanFunction(int m68, int n68)
{
    Console.Write(Akkerman(m68, n68));
}

int Akkerman(int m68, int n68)
{
    if (m68 == 0)
    {
        return n68 + 1;
    }
    else if (n68 == 0 && m68 > 0)
    {
        return Akkerman(m68 - 1, 1);
    }
    else
    {
        return (Akkerman(m68 - 1, Akkerman(m68, n68 - 1)));
    }
}

// Вводная функция:
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}