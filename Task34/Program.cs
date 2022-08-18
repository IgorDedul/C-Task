// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.WriteLine("Добрый день! Данная программа генерирует массив с трехзначными числами и определяет количество чётных элементов");
Console.WriteLine("");
int even = 0;

int[] NewArray()
{
    int[] array = new int [4];
    for (int i=0; i<4; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

int[] array = NewArray();

void ArrayPrint()
{
    Console.Write("[");

    for (int i=0; i<3; i++)
    {
        Console.Write($" {array[i]}, ");
    }
    Console.Write($" {array[3]}]");
}

ArrayPrint();
Console.WriteLine("");

int EvenNumber()
{
    for (int i=0; i<4; i++)
    {
        if (array[i] % 2 == 0)
        {
            even++;
        }
    }
    return even;
}

even = EvenNumber();
Console.WriteLine($"Количество чётных элементов в массиве {even}");