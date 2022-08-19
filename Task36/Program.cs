// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.WriteLine("Добрый день! Данная программа генерирует массив и считает сумму элементов стоящих на нечётных индексах");
Console.WriteLine("");
Console.WriteLine("Сколько элементов в массиве должно быть?");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int sum = 0;

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
        array[i] = new Random().Next(-100,100);
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

int SumNoEvenArray()
{
    for (int i=0; i<size; i++)
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