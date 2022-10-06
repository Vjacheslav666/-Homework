//Задача 2: 
//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int x2 = Convert.ToInt32(Console.ReadLine());

if (x1 > x2)
{
    Console.Write("Первое введённое число больше второго!");
}

if (x1 < x2)
{
    Console.Write("Второе введённое число больше первого!");
}
else if (x1 == x2)
{
    Console.Write("Введенные числа равны!");
}