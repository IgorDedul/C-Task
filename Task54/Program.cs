// /Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.WriteLine("Добрый день! Данная программа упорядочит по убыванию элементы каждой строки двумерного массива.");
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

int[,] newMatrix = NewMatrix();

void MatrixPrint(int[,] matrix)
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
MatrixPrint(newMatrix);

int[,] СorretMatrix(int[,] matrix)
{
    int temp = default;
    for (int i=0; i<row; i++)
        {
            for (int tempCol = col; tempCol > 0; tempCol--)     // При сортировке использую метод "пузырка": при проходе по строке каждым элементом раз 
            {                                                   // количеством элементов строки, при каждом проходе сравниваю элемент с следующим и 
                for (int j=0; j<tempCol-1; j++)                 // меняю местами, выталкивая меньшее значение в конец строки и сокращая проход 
                {                                               // выталкнутым элементом пока не переберу все.
                    if (matrix[i,j] < matrix[i,j+1])
                    {
                        temp = matrix[i,j+1];
                        matrix[i,j+1] = matrix[i,j];
                        matrix[i,j] = temp;
                    }
                }
            }    
        }
    return matrix;
}

int[,] correctMatrix = СorretMatrix(newMatrix);
Console.WriteLine("");
Console.WriteLine("Упорядоченная матрица по убыванию элементов:");
MatrixPrint(correctMatrix);
Console.WriteLine("");