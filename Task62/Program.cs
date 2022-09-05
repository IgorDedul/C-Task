// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.WriteLine("Добрый день! Данная программа заполнит спирально массив.");
Console.WriteLine("");
Console.WriteLine("Задайте размер квадратного массива:");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");


void CorrectInput()
{
    if (size <= 0)
    {
        Console.WriteLine("Вы ввели некорректный размер матрицы.");
    }
}

CorrectInput();

int[,] matrix = new int [size,size];

int[,] SpiralMatrix(int n, int sizeTemp)
{
    int count = 1;
    int maxCount = sizeTemp*sizeTemp;
    do
    {
        for (int j=n; j<sizeTemp; j++)
        {
            matrix[n,j] = count;
            count++;  
        }
        
        for (int i=n+1; i<sizeTemp; i++)
        {
            matrix[i,sizeTemp-1] = count;
            count++;  
        }

        sizeTemp--;

        for (int j=sizeTemp-1; j>=n; j--)
        {
            matrix[sizeTemp,j] = count;
            count++;  
        }
        for (int i=sizeTemp-1; i>n; i--)
        {
            matrix[i,n] = count;
            count++;  
        }
        n++;
    }
    while (count <= maxCount);
    return matrix;
}

matrix = SpiralMatrix(0, size);

void MatrixPrint()
{
    for (int i=0; i<size; i++)
    {
        Console.WriteLine("");
        Console.Write("[");
        for (int j=0; j<size; j++)
        {
        Console.Write($"\t {matrix[i,j]} \t");
        }
        Console.Write("]");
    }
}
Console.WriteLine("Выводим массив:");
Console.WriteLine("");
MatrixPrint();
Console.WriteLine("");