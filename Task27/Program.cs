// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("Добрый день! Данная программа считает сумму цифр в числе");
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int sum = default;

int SumNumber(int num)
{
do 
{
    sum = sum + (num % 10);
    num = num / 10; 
}
while (num != 0);
return sum;
}

sum = SumNumber(number);
Console.WriteLine($"Сумма чисел равна {sum}");
