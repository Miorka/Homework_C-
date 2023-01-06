double k1 = Func("Введите k1: ");
double b1 = Func("Введите b1: ");
double k2 = Func("Введите k2: ");
double b2 = Func("Введите b2: ");

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($"Точка пересечения имеет следующие координаты: ({x};{y})");

double Func(string text)
{
    double number;
    Console.Write(text);
    number = Convert.ToDouble(Console.ReadLine());
    return number;
}