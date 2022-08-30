// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Добрый день! Данная программа находит строку с наименьшей суммой элементов.");
Console.WriteLine("");
Console.WriteLine("Сколько строк должно быть в матрице?");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько столбцов должно быть в матрице?");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

void CorrectInput()
{
    if (col <= 0 || row <= 0)
    {
        Console.WriteLine("Вы ввели некорректный размер матрицы.");
    }
}

CorrectInput();

int[,] NewMatrix()
{
    int[,] matrix = new int [row,col];
    Random rnd = new Random();
    for (int i=0; i<row; i++)
    {
        for (int j=0; j<col; j++)
        {
        matrix[i,j] = rnd.Next(0,10);
        }
    }
    return matrix;
}

int[,] matrix = NewMatrix();

void MatrixPrint()
{
    for (int i=0; i<row; i++)
    {
        Console.WriteLine("");
        Console.Write("[");
        for (int j=0; j<col; j++)
        {
        Console.Write($"\t {matrix[i,j]} \t");
        }
        Console.Write("]");
    }
}
MatrixPrint();
Console.WriteLine("");
Console.WriteLine("Сумма элементов в каждой строке равна:");

int[] ArraySumRow()
{
    int[] array = new int [row];
    for (int i=0; i<row; i++)
    {
        for (int j=0; j<col; j++)
        {
            array[i] = array[i] + matrix[i,j];
        }
        Console.Write($"\t {array[i]} \t");
    }
    return array;
}
int[] array = ArraySumRow();
Console.WriteLine("");

int MinSumRow()
{
    int minSum = array[0];
    int minSumRow = 0;
    for (int i=1; i<row; i++)
        {
             if (array[i] < minSum)
            {
                minSum = array[i];
                minSumRow = i;
            }
        }
    return minSumRow;
}
int minSumRow = MinSumRow();
Console.WriteLine($"Строка № {minSumRow+1} с наименьшей суммой элементов.");
Console.WriteLine("");