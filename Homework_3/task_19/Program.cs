// Задача 19
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string num = number.ToString();

if ((number >= 10000) && (number < 100000))
{
  if (num[0] == num[4] && num[1] == num[3])
  {
      Console.WriteLine($"Введённое число {number} является палиндромом!");
  }
    
  else
  {
      Console.WriteLine($"Введённое число {number} не является палиндромом!");
  }
}

else if ((number < 10000) || (number >= 100000))
{
    Console.WriteLine("Введите пожалуйста пятизначное число!");
}