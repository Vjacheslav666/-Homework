//Задача 5: Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = n * -1;


while (i <= n)
{
    Console.WriteLine(i);
    i += 1;
}