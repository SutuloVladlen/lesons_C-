//Программа узнает втрую цифру трехзначного число

/*int namer = new Random().Next(100, 1000);

Console.WriteLine(namer);

int a = (namer % 100) / 10;

Console.WriteLine(a);
*/

// Нахождение третьей цифры любого числа
/*int namber = int.Parse(Console.ReadLine());
if (namber < 0)
{
    namber = namber * -1;
}
if (namber < 100)
{
    Console.WriteLine("Третьего числа нет");
}
else
{
    int therd_digit = namber % 1000 / 100;
    Console.WriteLine(therd_digit);
}
*/

// Определение выходного дня.
int day = int.Parse(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.WriteLine("Yes");
}
if (day > 0 && day < 6)
{
    Console.WriteLine("No");
}
if (day < 1 || day > 7)
{
    Console.WriteLine("Incorrect data");
}
