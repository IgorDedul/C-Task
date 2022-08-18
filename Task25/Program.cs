// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Добрый день! Данная программа возводит заданное число в заданную степень.");
Console.WriteLine("Введите возводимое число:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень:");
int deg = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

int ResNumber(int number)
{
    int result = 1;
    for (int i=1; i<=deg; i++)
    {
        result = result * number;
    }
    return result;
}

if (deg > 0)
{
    int result = ResNumber(num);    
    Console.WriteLine($"Число {num} в степени {deg} составляет: {result}");
}
else Console.WriteLine("Введено некорректное число!");
