// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их 
// на экран.

int [] n = new int[8];
Fill(n);

void Fill(int[] massiw)
{
    int m = massiw.Length;
    int ind = 0;
    while (ind < m)
    {
        massiw[ind] = new Random().Next(0, 100);
        Console.Write(massiw[ind] + " ");
        ind++;
    }
}
