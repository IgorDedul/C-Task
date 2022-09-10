// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.WriteLine("Добрый день! Данная программа выведет все натуральные числа в промежутке от N до 1.");
Console.WriteLine("");
Console.WriteLine("Укажите значение N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

void CorrectInput()
{
    if (n <= 1)
    {
        Console.WriteLine("Вы ввели некорректное число.");
    }
}

CorrectInput();

void NaturalNum(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNum(num-1);
}

Console.WriteLine("Ваш результат:");
NaturalNum(n);
Console.WriteLine("");