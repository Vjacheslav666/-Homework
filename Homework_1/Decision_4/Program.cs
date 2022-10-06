//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i < N)
{
    Console.WriteLine(i + 1);
    i += 2;
}