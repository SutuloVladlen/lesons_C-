int ImputInt()
{
    Console.WriteLine("Ввелите число");

    bool namber = int.TryParse(Console.ReadLine(), out int nam);

    if (!namber)
    {
        Console.WriteLine("Ввели не корректно данные");
        return -1;
    }
    else
    {
        return nam;
    }
}
int nam = ImputInt();
int[] GetTebleOfCube(int nam)
{
    int[] arr = new int[nam];
    for (int i = 0; i < nam; i++)
    {
        arr[i] = (int)(Math.Pow(i, 3));
    }
    return arr;
}

int[] resalt = GetTebleOfCube(nam);
void PrintArray(int[] arr)
{
    for (int i = 0; i < nam; i++)
    {
        Console.Write($"{arr[i]} ");
    }

}
PrintArray(resalt);


