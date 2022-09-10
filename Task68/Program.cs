// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Добрый день! Данная программа вычисляет функцию Аккермана");
Console.WriteLine("");
Console.WriteLine("Укажите неотрицательное число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите число неотрицательное N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int result = default;

void CorrectInput()
{
    if (n <= 0 || m <= 0)
    {
        Console.WriteLine("Вы ввели некорректное число.");
    }
}

CorrectInput();

int FunctionAkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return FunctionAkerman(m - 1, 1);
    else return FunctionAkerman(m - 1, FunctionAkerman(m, n - 1));
}

result = FunctionAkerman(m,n);
Console.WriteLine($"A({m},{n}) = {result} ");
Console.WriteLine("");