Console.Clear();
Console.WriteLine("Домашняя работа восьмого семинара!");
Console.WriteLine("Тут находятся домашние задания под номером 54, 56, 58, 60, 62.");
int task = EnteringAnumber("Введите номер домашнего задания: ");
Console.WriteLine();

switch(task)
{
    case 54:
        Console.WriteLine("Задача 54:");
        Console.WriteLine("Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
        int m54 = EnteringAnumber("Введите колличество строк в массиве: ");
        int n54 = EnteringAnumber("Введите колличество столбов в массиве: ");
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
        int count56 = EnteringAnumber("Введите размер массива: ");
        int[,] numbers56 = new int[count56, count56];
        RandomMassive56(numbers56);
        SunNumbers56(numbers56);
        break;
    case 58:
        Console.WriteLine("Задача 58:");
        Console.WriteLine("Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
        Console.WriteLine();
        int size = EnteringAnumber("Размеры матриц: ");
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
        int num1 = EnteringAnumber("Введите размерность 1: ");
        int num2 = EnteringAnumber("Введите размерность 2: ");
        int num3 = EnteringAnumber("Введите размерность 3: ");
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
        int number62 = EnteringAnumber("Введите размер массива: ");
        int[,] nums = new int[number62, number62];
        Console.WriteLine();
        TaskNumber62(number62, nums);
        PrintNumber62(nums);
        Console.WriteLine();
        break;
}

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


// Вводная функция!
int EnteringAnumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}