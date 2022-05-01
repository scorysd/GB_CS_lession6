// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
Console.Clear();
Console.WriteLine("Введите K1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите B1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите K2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите B2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
if (k1==k2 && b1==b2)
{
    Console.WriteLine($"Прямые совпадают (бесконечное множество точек пересечения)");
}
else if (k1==k2)
{
    Console.WriteLine($"Прямые параллельны");
}
else
{
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Прямые с заданными коородинатами пересекаются в точке ({x} . {y})");
}