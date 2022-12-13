// Console.WriteLine("Введите длинну первой стороны");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите длинну второй стороны");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите длинну третьей стороны");
// int c = int.Parse(Console.ReadLine());
// bool x = Triangle(a, b, c);
// Console.WriteLine(x);

// bool Triangle(int a, int b, int c)

// {
//     if (a < b + c && b < a + c && c < a + b)
//     {
//         return true;
//     }
//     return false;
// }


// Console.WriteLine("Введите число");
// int x = int.Parse(Console.ReadLine());

// int[] nambers = ConvertingTheBinary(x);
// PrintArray(nambers);

// int[] ConvertingTheBinary(int x)
// {
//     int count = 0;
//     int n = x;
//     while (x > 0)
//     {
//         x /= 2;
//         count++;
//     }

//     int[] arr = new int[count];
//     for (int i = 0; i < count; i++)
//     {
//         arr[i] = n % 2;
//         n = n / 2;
//     }
//     return arr;
// }
// void PrintArray(int[] nambers)
// {
//     for (var i = 0; i < nambers.Length; i++)
//     {
//         Console.Write($"{nambers[i]}");
//     }

//     // string message = string.Join(" ,", nambers);
//     // Console.WriteLine($"{string.Join(" ,", nambers)}");
// }


// Console.WriteLine("Введите число");
// int x = int.Parse(Console.ReadLine());

// int[] resalt = Fibanach(x);
// PrintArray(resalt);
// int[] Fibanach(int x)
// {
//     int[] arr = new int[x];
//     arr[0] = 0;
//     arr[1] = 1;
//     for (int i = 2; i < x; i++)
//     {
//         arr[i] = arr[i - 1] + arr[i - 2];
//     }
//     return arr;
// }
// void PrintArray(int[] resalt)
// {
//     // Console.Write("[");
//     // for (var i = 0; i < array.Length; i++)
//     // {

//     //     Console.Write($"{array[i]},");

//     // }
//     // Console.Write("]");
//     string message = string.Join(" ,", resalt);
//     Console.WriteLine($"{string.Join(" ,", resalt)}");

//     //Console.WriteLine("[{0}]", string.Join(", ", array));
// }

// int FaindMinNamber(int[] array)
// {
//     int min = array[0];
//     for (var i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min)
//             min = array[i];

//     }
//     return min;
// }



// int[] array = GenerateArray(100, 999, 20);
// PrintArray(array);
// int[] arr = CopyArray(array);
// PrintArr(arr);
// int[] CopyArray(int[] array)

// {
//     int[] arr = new int[array.Length];

//     for (var i = 0; i < arr.Length; i++)
//     {
//         arr[i] = array[i];
//     }

//     return arr;
// }


// int[] GenerateArray(int min, int max, int length)
// {
//     Random random = new Random();
//     int[] array = new int[length];

//     for (var i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
//     }

//     return array;
// }

// void PrintArray(int[] array)
// {
//     // Console.Write("[");
//     // for (var i = 0; i < array.Length; i++)
//     // {

//     //     Console.Write($"{array[i]},");

//     // }
//     // Console.Write("]");
//     string message = string.Join(" ,", array);
//     Console.WriteLine($"[{string.Join(" ,", array)}]");

//     //Console.WriteLine("[{0}]", string.Join(", ", array));
// }
// void PrintArr(int[] arr)
// {
//     // Console.Write("[");
//     // for (var i = 0; i < array.Length; i++)
//     // {

//     //     Console.Write($"{array[i]},");

//     // }
//     // Console.Write("]");
//     string message = string.Join(" ,", arr);
//     Console.WriteLine($"[{string.Join(" ,", arr)}]");

//     //Console.WriteLine("[{0}]", string.Join(", ", array));
// }
// int m = int.Parse(Console.ReadLine());
// int n = int.Parse(Console.ReadLine());

// int[,] array = SumIndex(m, n);
// PrintArr(array);
// int[,] SumIndex(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = i + j;
//         }

//     }
//     return array;
// }
// void PrintArr(int[,] array)
// {
//     // Console.Write("[");
//     for (var i = 0; i < array.GetLength(0); i++)
//     {
//         for (var j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]},");
//         }
//         Console.WriteLine();
//     }
//     // Console.Write("]");
//     // string message = string.Join(" ,", arr);
//     // Console.WriteLine($"[{string.Join(" ,", arr)}]");

//     //Console.WriteLine("[{0}]", string.Join(", ", array));
// }
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[,] array = CompletionArray(m, n);
PrintArr(array);
Console.WriteLine();
int sum = OddIndex(array);
Console.WriteLine(sum);
int[,] CompletionArray(int m, int n)
{
    Random random = new Random();

    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            {
                array[i, j] = random.Next(1, 10);
            }

        }

    }
    return array;
}
int OddIndex(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            {
                if (i == j)
                    sum = sum + array[i, j];
            }
        }

    }
    return sum;
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
    // string message = string.Join(" ,", arr);
    // Console.WriteLine($"[{string.Join(" ,", arr)}]");

    //Console.WriteLine("[{0}]", string.Join(", ", array));
}

