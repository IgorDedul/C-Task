// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("Добрый день! Данная программа находит произведение двух матриц.");
Console.WriteLine("");
Console.WriteLine("Задайте размер квадратной матрицы:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int col = row;
Console.WriteLine("");

void CorrectInput()
{
    if (col <= 0 || row <= 0)
    {
        Console.WriteLine("Вы ввели некорректный размер матрицы.");
    }
}

CorrectInput();

int[,] NewMatrix(int rowmatrix, int colmatrix)
{
    int[,] matrix = new int [rowmatrix,colmatrix];
    Random rnd = new Random();
    for (int i=0; i<rowmatrix; i++)
    {
        for (int j=0; j<colmatrix; j++)
        {
        matrix[i,j] = rnd.Next(0,10);
        }
    }
    return matrix;
}

int[,] matrix1 = NewMatrix(row,col);
int[,] matrix2 = NewMatrix(col,row);

void MatrixPrint(int[,] matrix, int rowmatrix, int colmatrix)
{
    for (int i=0; i<rowmatrix; i++)
    {
        Console.WriteLine("");
        Console.Write("[");
        for (int j=0; j<colmatrix; j++)
        {
        Console.Write($"\t {matrix[i,j]} \t");
        }
        Console.Write("]");
    }
}
Console.WriteLine("");
Console.WriteLine("Получаем первую матрицу:");
MatrixPrint(matrix1,row,col);
Console.WriteLine("");
Console.WriteLine("и вторую:");
MatrixPrint(matrix2,col,row);
Console.WriteLine("");

int[,] MultipliedMatrix(int rowmatrix, int colmatrix)
{
    int mult = default;
    int[,] matrix = new int [rowmatrix,colmatrix];
    for (int i=0; i<rowmatrix; i++)
    {
        for (int j=0; j<colmatrix; j++)
        {
            mult = 0;
            for (int n=0; n<rowmatrix; n++)
            {
                mult = mult + (matrix1[i,n] * matrix2[n,j]);
            }
            matrix[i,j] = mult;
        }
    }
    return matrix;
}

int[,] multmatrix = MultipliedMatrix(row,row);
Console.WriteLine("Матрица полученная путём произведения:");
MatrixPrint(multmatrix,row,row);
Console.WriteLine("");