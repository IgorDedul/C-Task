// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Добрый день! Данная программа находит максимальное из трёх чисел.");
Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Число {a} больше, чем число {b}");   
}
else if (a < b)
{
    Console.WriteLine($"Число {b} больше, чем число {a}");
}
else
{
    Console.WriteLine($"Числа {a} и {b} равны.");
}
