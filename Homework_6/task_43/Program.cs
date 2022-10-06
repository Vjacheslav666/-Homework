// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
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

void taskNumber43(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"X = {x}, Y = {y}");
    if(x == 0 && y == 0)
    Console.WriteLine("Пряпые не пересекаются!");
    Console.WriteLine();
}

