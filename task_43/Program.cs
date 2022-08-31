// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1 :");
double b1Value = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k1 :");
double k1Value = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение b2 :");
double b2Value = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k2 :");
double k2Value = Convert.ToDouble(Console.ReadLine());

double xVar = (b2Value - b1Value) / (k1Value - k2Value);

double yVar = k1Value * xVar + b1Value;

Console.WriteLine($" x = {xVar}, y = {yVar}");