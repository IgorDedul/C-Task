// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.WriteLine("Добрый день! Данная программа генерирует массив и считает сумму элементов стоящих на нечётных индексах");
Console.WriteLine("");
int sum = 0;

int[] NewArray()
{
    int[] array = new int [4];
    for (int i=0; i<4; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
    return array;
}

int[] array = NewArray();

void ArrayPrint()
{
    int i=0;
    Console.Write("[");

    for (i=0; i<3; i++)
    {
        Console.Write($" {array[i]}, ");
    }
    Console.Write($" {array[i]}]");
}

ArrayPrint();
Console.WriteLine("");

int SumNoEvenArray()
{
    for (int i=0; i<4; i++)
    {
        if (i%2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

sum = SumNoEvenArray();
Console.WriteLine($"Количество нечётных элементов в массиве {sum}");