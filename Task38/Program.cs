// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


Console.WriteLine("Добрый день! Данная программа генерирует массив вещественных чисел и считает разницу между максимальным и минимальными элементами");
Console.WriteLine("");
Console.WriteLine("Сколько элементов в массиве должно быть?");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько знаков после запятой должно быть в вещественных числах элементов массива?");
int sign = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

void CorrectInput()
{
    if (size <= 0 || sign <= 0)
    {
        Console.WriteLine("Вы ввели некорректную длину массива.");
    }
}

CorrectInput();

double[] NewArray()
{
    double[] array = new double [size];
    for (int i=0; i<size; i++)
    {
        array[i] = new Random().NextDouble()*100;
        array[i] = Math.Round(array[i], sign);
    }
    return array;
}

double[] array = NewArray();

void ArrayPrint()
{
    int i=0;
    Console.Write("[");

    for (i=0; i<size-1; i++)
    {
        Console.Write($" {array[i]}; ");
    }
    Console.Write($" {array[i]}]");
}

ArrayPrint();
Console.WriteLine("");

void DiffMinMax()
{
    double min = array[0];
    double max = array[0];
    for (int i=1; i<size; i++)
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
    double diff = max - min;
    diff = Math.Round(diff, sign);
    Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементом массива составляет {diff}");
}

DiffMinMax();