using Common;
Console.WriteLine("Введите число которое будет показывать количество столбцов в первой матрице и количество строк во второй.Равенство показателей является обязательным условиемю");
int m = int.Parse(Console.ReadLine());
int[,] array1 = Helper.GenerateRandomArray(3, m, 0, 10);
int[,] array2 = Helper.GenerateRandomArray(m, 2, 0, 10);
Helper.PrintArray(array1);
Console.WriteLine();
Helper.PrintArray(array2);
int[,] resalt = MultiplicationMatrix(array1, array2);
Console.WriteLine("Произведение массивов");
Helper.PrintArray(resalt);


int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,] resalt = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array2.GetLength(1); i++)
    {
        for (int j = 0; j < array1.GetLength(0); j++)
        {
            int sum = 0;
            for (int x = 0; x < array1.GetLength(1); x++)
            {

                sum = sum + (array1[j, x] * array2[x, i]);
            }
            resalt[j, i] = sum;
        }
    }
    return resalt;
}