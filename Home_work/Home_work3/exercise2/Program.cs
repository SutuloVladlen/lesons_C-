Console.WriteLine("Введите кординаты первой точки");
bool coordinates1X = int.TryParse(Console.ReadLine(), out int x1);
bool coordinates1Y = int.TryParse(Console.ReadLine(), out int y1);
bool coordinates1Z = int.TryParse(Console.ReadLine(), out int z1);

Console.WriteLine("Введите кординаты второй точки");
bool coordinates2X = int.TryParse(Console.ReadLine(), out int x2);
bool coordinates2Y = int.TryParse(Console.ReadLine(), out int y2);
bool coordinates2Z = int.TryParse(Console.ReadLine(), out int z2);

if (!coordinates1X && !coordinates1Y && !coordinates1Z && !coordinates2X && !coordinates2Y && !coordinates2Z)
{
    Console.WriteLine("Введены некорректные данные");
    return;
}

double lengh = lenght(x1, x2, y1, y2, z1, z2);
Console.WriteLine(lengh);

double lenght(int x1, int x2, int y1, int y2, int z1, int z2)
{

    double x12 = Math.Pow((x1 - x2), 2);
    double y12 = Math.Pow((y1 - y2), 2);
    double z12 = Math.Pow((z1 - z2), 2);
    double sum = x12 + y12 + z12;
    double resalt = Math.Pow((sum), 0.5);
    {
        return resalt;
    }
}
