﻿// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= num)
{
    int x = count % 2;
    if (x == 0)
    {
        Console.Write($"{count}, ");
    }
    count++;
}
