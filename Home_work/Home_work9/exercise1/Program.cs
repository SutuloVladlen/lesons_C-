Console.WriteLine("Введите число");
bool namber = int.TryParse(Console.ReadLine(), out int n);
if (!namber)
{
    Console.WriteLine("Введены некорректные данные.");
    return;
}
Integers(n);
void Integers(int n)
{
    if (n == 1)
    {
        Console.Write(n);
        return;
    }
    if (n < 1)
    { return; }
    Console.Write($"{n},");
    Integers(n - 1);

}