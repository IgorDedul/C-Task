// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Добрый день! Данная программа определяет точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("");
Console.WriteLine("Введите числовое значение b1:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числовое значение k1:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числовое значение b2:");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числовое значение k2:");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");


double IntersectionLineX()
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double x = IntersectionLineX();

double IntersectionLineY()
{
    double y = k1 * x + b1;
    return y;
}

double y = IntersectionLineY();
Console.WriteLine($"Координаты точки пнресечения: ({x};{y}).");