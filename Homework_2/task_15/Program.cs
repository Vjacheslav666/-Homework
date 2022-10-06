// Задача 15.
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number == 6) || (number == 7))
{
    Console.WriteLine("Ура, выходной!");
}

else if (number > 0 && number < 6)
{
    Console.WriteLine("Этот день рабочий!");
}

else if (number <= 0 || number > 7)
{
    Console.WriteLine("В неделе только 7 дней!");
}