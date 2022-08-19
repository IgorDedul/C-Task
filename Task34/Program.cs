// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.WriteLine("Добрый день! Данная программа генерирует массив с трехзначными числами и определяет количество чётных элементов");
Console.WriteLine("");
Console.WriteLine("Сколько элементов в массиве должно быть?");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int even = 0;

void CorrectInput()
{
    if (size <= 0)
    {
        Console.WriteLine("Вы ввели некорректную длину массива.");
    }
}

CorrectInput();

int[] NewArray()
{
    int[] array = new int [size];
    for (int i=0; i<size; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

int[] array = NewArray();

void ArrayPrint()
{
    int i=0;
    Console.Write("[");

    for (i=0; i<size-1; i++)
    {
        Console.Write($" {array[i]}, ");
    }
    Console.Write($" {array[i]}]");
}

ArrayPrint();
Console.WriteLine("");

int EvenNumber()
{
    for (int i=0; i<size; i++)
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