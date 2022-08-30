// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


Console.WriteLine("Добрый день! Данная программа генерирует матрицу вещественных чисел.");
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

double[,] NewMatrix()
{
    double[,] matrix = new double [row,col];
    for (int i=0; i<row; i++)
    {
        for (int j=0; j<col; j++)
        {
        matrix[i,j] = new Random().NextDouble()*200-100;
        matrix[i,j] = Math.Round(matrix[i,j], 1);
        }
    }
    return matrix;
}

double[,] matrix = NewMatrix();

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