// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Добрый день! Данная программа находит среднее арифметическое элементов в каждом столбце.");
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
Console.WriteLine("Среднее арефметическое столбцов соответственно:");

void ArithmeticMeanCol()
{
    double arithmeticMean = default;
    for (int j=0; j<col; j++)
    {
        arithmeticMean = 0;
        for (int i=0; i<row; i++)
        {
            arithmeticMean = arithmeticMean + matrix[i,j];
        }
        Console.Write($"\t {arithmeticMean/row} \t");
    }
}

ArithmeticMeanCol();
Console.WriteLine("");