// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Добрый день! Данная программа расчитывает таблицу кубов до указанного Вами числа.");
Console.WriteLine("Введите крайнее число таблицы кубов:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

if (n > 0)
{
    for (int i=0; i<=n; i++)
    {
        Console.WriteLine($"{i}\t{i*i*i}");
    }

}
else Console.WriteLine("Введено некорректное число!");