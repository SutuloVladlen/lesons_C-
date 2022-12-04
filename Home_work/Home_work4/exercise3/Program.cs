int nam = 8;
int[] GetTebleOfCube(int nam)
{
    int[] arr = new int[nam];
    for (int i = 0; i < nam; i++)
    {
        Random r = new Random();
        int n = r.Next(0, 100);

        arr[i] = n;
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
Console.Write("[");
PrintArray(resalt);
Console.Write("]");
//немного не понял что конкретно нужно было сделать в задании, но надеюсь что сделал то.
