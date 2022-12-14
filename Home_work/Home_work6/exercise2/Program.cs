Console.WriteLine("Введите значения для уравнения прямых");
bool numberK1 = int.TryParse(Console.ReadLine(), out int k1);
bool numberB1 = int.TryParse(Console.ReadLine(), out int b1);
bool numberK2 = int.TryParse(Console.ReadLine(), out int k2);
bool numberB2 = int.TryParse(Console.ReadLine(), out int b2);

if (!numberK1 && !numberK2 && !numberB1 && !numberB2)
{
    Console.WriteLine("Ввели не корректно данные");
    return;
}

(double, double) coordinates = FandingIntersectionPoint(k1, k2, b1, b2);
Console.WriteLine($"({coordinates.Item1}:{coordinates.Item2})");

(double, double) FandingIntersectionPoint(int k1, int k2, int b1, int b2)
{   //double x = (b2-b1)/(k1-k2) при такой записи код не работал , я не смог понять почему
    double b = b2 - b1;
    double k = k1 - k2;
    double x = b / k;
    double y = k2 * x + b2;
    return (x, y);
}