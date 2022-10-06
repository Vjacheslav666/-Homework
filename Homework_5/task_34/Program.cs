// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива:  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("массив: ");
// PrintArray(numbers);
// int count = 0;

// for (int z = 0; z < numbers.Length; z++)
// if (numbers[z] % 2 == 0)
// count++;

// Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }

// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }


Console.Clear();
Console.Write("Введите размер массива:  ");
int coll34 = Convert.ToInt32(Console.ReadLine());
int[] mass34 = new int[coll34];
Console.WriteLine();
Console.WriteLine("массив: ");
TaskNumber34(mass34);
Console.WriteLine();


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