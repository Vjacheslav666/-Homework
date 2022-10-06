// Задача 64: 
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 5, 6, 7, 8""

// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Домашняя работа девятого семинара!");
Console.WriteLine("Тут находятся домашние задания под номером 64, 66, 68.");
int task = EnteringAnumber("Введите номер домашнего задания: ");
Console.WriteLine();

switch(task)
{
    case 64:
        Console.WriteLine("Задача 64:");
        Console.WriteLine("Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
        int m64 = EnteringAnumber("Введите число M: ");
        int n64 = EnteringAnumber("Введите число N: ");
        Console.WriteLine();
        TaskNumber64(m64, n64);
        Console.WriteLine();
        break;
    case 66:
        Console.WriteLine("Задача 66:");
        Console.WriteLine("Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
        int m66 = EnteringAnumber("Введите число M: ");
        int n66 = EnteringAnumber("Введите число N: ");
        Console.WriteLine();
        string result66 = TaskNumber66(m66, n66);
        Console.WriteLine(result66);
        Console.WriteLine();
        break;
    case 68:
        Console.WriteLine("Задача 68:");
        Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N.");
        int m68 = EnteringAnumber("Введите число M: ");
        int n68 = EnteringAnumber("Введите число N: ");
        Console.WriteLine();
        if(n68 < 0 && m68 < 0)
        {
            Console.WriteLine($"Вы ввели отрицательное число M {m68}.");
            Console.WriteLine();
            Console.WriteLine($"Вы ввели отрицательное число N {n68}.");
            Console.WriteLine();
            return;
        }
        else if(m68 < 0)
        {
            Console.WriteLine($"Вы ввели отрицательное число M {m68}.");
            Console.WriteLine();
            return;
        }
        else if(n68 < 0)
        {
            Console.WriteLine($"Вы ввели отрицательное число N {n68}.");
            Console.WriteLine();
            return;
        }
        AkkermanFunction(m68,n68);
        break;
}

// Задача 64:
void TaskNumber64(int m64, int n64)
{
    if(m64 < n64)
    {
        for(int i = m64; i <= n64; i++)
        {
            Console.Write($"{i},  ");
        }
    }

    else if(m64 > n64)
    {
        for(int i = m64; i >= n64; i--)
        {
            Console.Write($"{i},  ");
        }
    }

    else if(m64 == n64)
    {
        Console.WriteLine("Введённые числа M и N равны!");
    }
}

// Задача 66:
string TaskNumber66(int m66, int n66)
{
    string result66 = string.Empty;
    int count = 0;
    if(m66 < n66)
    {
        for(int i = m66; i <= n66; i++)
        {
            count = count + i;
            result66 = $"Сумма всех натуральных элементов в промежутке от {m66} до {n66} равна {count}";
        }
        return result66;
    }

    else if(m66 > n66)
    {
        for(int i = m66; i >= n66; i--)
        {
            count = count + i;
            result66 = $"Сумма всех натуральных элементов в промежутке от {m66} до {n66} равна {count}";
        }
        return result66;
    }

    else if(m66 == n66)
    {
        result66 = "Введённые числа M и N равны!";
    }
    return result66;
}

// Задача 68:
void AkkermanFunction(int m68, int n68)
{
    Console.Write(Akkerman(m68, n68));
}

int Akkerman(int m68, int n68)
{
    if (m68 == 0)
    {
        return n68 + 1;
    }
    else if (n68 == 0 && m68 > 0)
    {
        return Akkerman(m68 - 1, 1);
    }
    else
    {
        return (Akkerman(m68 - 1, Akkerman(m68, n68 - 1)));
    }
}

// Вводная функция!
int EnteringAnumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}