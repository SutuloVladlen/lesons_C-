using Common;
int[,] array = GetSpire(4);
Helper.PrintArray(array);
int[,] GetSpire(int n)
{
    int[,] array = new int[n, n];
    int i = 0;
    int j = 0;
    int namber = 1;
    int k = 0;
    while (n != 0)
    {
        do { array[i, j++] = namber++; }
        while (++k < n - 1);
        for (k = 0; k < n - 1; k++)
        {
            array[i++, j] = namber++;
        }
        for (k = 0; k < n - 1; k++)
        {
            array[i, j--] = namber++;
        }
        for (k = 0; k < n - 1; k++)
        {
            array[i--, j] = namber++;
        }
        ++i;
        ++j;
        n = n < 2 ? 0 : n - 2;
    }
    return array;
}
