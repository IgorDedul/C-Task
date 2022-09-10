// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.WriteLine("Добрый день! Данная программа построчно выводит трехмерный массив, добавляя индексы каждого элемента.");
Console.WriteLine("");
Console.WriteLine("Укажите количество строк:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество столбцов:");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите количество слоёв:");
int lay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

void CorrectInput()
{
    if (col <= 0 || row <= 0 || lay <= 0)
    {
        Console.WriteLine("Вы ввели некорректный размер матрицы.");
    }
}

CorrectInput();

int[,,] NewMatrix()
{
    int[,,] matrix = new int [row,col,lay];
    Random rnd = new Random();
    for (int i=0; i<row; i++)
    {
        for (int j=0; j<col; j++)
        {
            for (int k=0; k<lay; k++)
            {
                matrix[i,j,k] = rnd.Next(10,100);
            }
        }
    }
    return matrix;
}

int[,,] matrix = NewMatrix();

void MatrixPrint()
{
    for (int i=0; i<row; i++)
    {
        for (int j=0; i<col; j++)
        {
            Console.WriteLine("");
            Console.Write("[");
            for (int k=0; k<lay; k++)
            {
                Console.Write($"\t {matrix[i,j,k]} ({i};{j};{k}) \t");
            }
            Console.Write("]");
        }
    }
}
Console.WriteLine("Получаем трехмерную матрицу:");
MatrixPrint();
Console.WriteLine("");
