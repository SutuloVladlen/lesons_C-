Console.WriteLine("Введите количество строк");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позицию элемента");
int yPosition = int.Parse(Console.ReadLine());
int xPosition = int.Parse(Console.ReadLine());

Random random = new Random();


int[,] array = RandomArray2(y, x);
PrintArr(array);
(int, bool) resalt = ExaminationPosition(array, yPosition, xPosition);

if (resalt.Item2 == false)
{
    Console.WriteLine("Такого элемента нет");
}

else
{
    Console.WriteLine(resalt.Item1);
}
int[,] RandomArray2(int y, int x)
{
    int[,] array = new int[y, x];
    for (int i = 0; i < y; i++)
    {
        for (int j = 0; j < x; j++)
        {
            array[i, j] = random.Next(-100, 100);
        }
    }
    return array;
}

(int, bool) ExaminationPosition(int[,] array, int yPosition, int xPosition)
{
    int fals = -1;
    if (array.GetLength(0) >= yPosition + 1 && array.GetLength(1) >= xPosition + 1 &&
        yPosition >= 0 && xPosition >= 0)
    {
        return (array[yPosition, xPosition], true);
    }
    else
        return (fals, false);
}

void PrintArr(int[,] array)
{
    // Console.Write("[");
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]},");
        }
        Console.WriteLine();
    }
    // Console.Write("]");
}