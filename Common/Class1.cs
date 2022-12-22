namespace Common;
public static class Helper
{
    static Random random = new Random();
    public static void PrintArray(int[,] array)
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
    public static int[,] GenerateRandomArray(int lengthY, int lengthX, int min, int max)
    {
        int[,] array = new int[lengthY, lengthX];
        for (int i = 0; i < lengthY; i++)
        {
            for (int j = 0; j < lengthX; j++)
            {
                array[i, j] = random.Next(min, max + 1);
            }
        }
        return array;
    }
    public static void PrintArray(int[] array)
    {
        // Console.Write("[");
        // for (var i = 0; i < array.Length; i++)
        // {
        //     Console.Write($"{array[i]},");
        // }
        // Console.Write("]");
        string message = string.Join(" ,", array);
        Console.WriteLine($"[{string.Join(" ,", array)}]");

        //Console.WriteLine("[{0}]", string.Join(", ", array));
    }
    public static int[] GenerateRandomArray(int min, int max, int length)
    {

        int[] array = new int[length];

        for (var i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(min, max + 1);
        }

        return array;
    }
}
