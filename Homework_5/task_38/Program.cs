// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Console.Clear();
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int z = 0; z < numbers.Length; z++)
// {
//     if (numbers[z] > max)
//         {
//             max = numbers[z];
//         }
//     if (numbers[z] < min)
//         {
//             min = numbers[z];
//         }
// }

// Console.WriteLine($"Всего {numbers.Length} чисел. \nМаксимальное значение = {max}, \nминимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// void FillArrayRandomNumbers(double[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//         }
// }
// void PrintArray(double[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }

Console.Clear();
Console.Write("Введите размер массива: ");
int coll38 = Convert.ToInt32(Console.ReadLine());
double[] mass38 = new double[coll38];
Console.WriteLine("Вот наш массив: ");
TaskNumber38(mass38);

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