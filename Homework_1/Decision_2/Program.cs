//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
//максимальное из этих чисел.
Console.Write("Введите первое число: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int x3 = Convert.ToInt32(Console.ReadLine());

if (x1 > x2 && x1 > x3)
{
    Console.Write("Первое введенное число больше!");
}

else if (x2 > x1 && x2 > x3)
{
    Console.Write("Второе введенное число больше!");
}

else if (x3 > x2 && x3 > x1)
{
    Console.Write("Третье введенное число больше!");
}

else if (x1 == x2 && x2 == x3 && x3 == x1)
{
    Console.Write("Введенные числа равны!");
}

else if (x1 == x2 && x1 != x3)
{
    Console.Write("Первое и второе числа равны, но больше третьего!");
}

else if (x2 == x3 && x2 != x1)
{
    Console.Write("Второе и третье числа равны, но больше первого!");
}

else if (x1 == x3 && x1 != x2)
{
    Console.Write("Первое и третье числа равны, но больше второго!");
}