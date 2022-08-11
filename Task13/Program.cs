// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Добрый день! Данная программа показывает третью цифру числа.");
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1; //Счётчик определения порядка
int remain = num;

if (num >=100 || num <=-100)
{
    do
    {
        remain = remain / 10;
        i = i * 10;
    }
    while (remain !=0);

    i = i / 1000;
    num = num / i;
    num = num % 10;
    Console.WriteLine($"Третья цифра {num}");
}
else
{
    Console.WriteLine($"В вашем числе {num} третья цифра отсутствует!");   
}