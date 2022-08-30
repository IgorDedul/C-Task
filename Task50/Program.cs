// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет


Console.WriteLine("Добрый день! Данная программа находит указанный элемент матрицы .");
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
        matrix[i,j] = rnd.Next(0,100);
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
Console.WriteLine("Укажите строку искомого элемента");
int rowSearch = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите столбец искомого элемента");
int colSearch = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

void SearchNum()
{
    if (colSearch <= 0 || colSearch > col || rowSearch <= 0 || rowSearch > row)
    {
        Console.WriteLine("Данного элемента в матрице не существует.");
    }
    else
    {
        Console.WriteLine($"Искомый элемент: {matrix[rowSearch-1,colSearch-1]}");
    }
}

SearchNum();