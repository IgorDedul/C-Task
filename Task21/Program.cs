// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Добрый день! Данная программа расчитывает расстояние между точками в трёхмерном пространстве.");

Console.WriteLine("Введите координату X для первой точки:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y для первой точки:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z для первой точки:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X для второй точки:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y для второй точки:");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z для второй точки:");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");

double result = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));  

Console.WriteLine("Расстояние между точками равно {0:#.##}", result);