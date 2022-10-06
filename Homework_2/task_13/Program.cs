// Задача 13.
// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Random num = new Random();
int number = num.Next(0, 1000);
Console.WriteLine("Рандомное число: " + number);

if (number >= 100 && number < 1000)
{
    int number3 = number % 10;
    Console.WriteLine("Третья цифра рандомного числа: " + number3);
}

else
{
    Console.WriteLine("Третьей цифры нет!");
}