﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Добрый день! Данная программа покачывает все чётные числа до заданного числа.");
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
Console.WriteLine("Чётные числа:");

do 
{
    i++;
    int remain = i % 2;

    if (remain == 0)
    {
        Console.Write($" {i},");   
    }
}
while (i < n);
Console.WriteLine("");