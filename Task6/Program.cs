﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Добрый день! Данная программа определяет чётность числа.");
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

int remain = a % 2;

if (remain == 0)
{
   Console.WriteLine($"Число {a} чётное.");   
}
else
{
   Console.WriteLine($"Число {a} нечётное.");
}