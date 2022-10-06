// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.Clear();
// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// int sum = 0;

// for (int z = 1; z < numbers.Length; z+=2)
//     sum = sum + numbers[z];

//     Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(1,10);
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
Console.Write("Введите размер массива: ");
int coll36 = Convert.ToInt32(Console.ReadLine());
int[] numbers36 = new int[coll36];
Console.WriteLine("Вот наш массив: ");
TaskNumber36(numbers36);


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