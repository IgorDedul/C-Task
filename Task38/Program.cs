// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


Console.WriteLine("Добрый день! Данная программа генерирует массив вещественных чисел и считает разницу между максимальным и минимальными элементами");
Console.WriteLine("");
int diff = 0;

int[] NewArray()
{
    int[] array = new int [8];
    for (int i=0; i<8; i++)
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

    for (i=0; i<7; i++)
    {
        Console.Write($" {array[i]}, ");
    }
    Console.Write($" {array[i]}]");
}

ArrayPrint();
Console.WriteLine("");

int DiffMinMax()
{
    int min = array[0];
    int max = array[0];
    for (int i=1; i<8; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }
    diff = max - min;
    return diff;
}

diff = DiffMinMax();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива составляет {diff}");