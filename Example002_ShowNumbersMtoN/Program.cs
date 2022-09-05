//Показать натуральные числа от M до N, N и M заданы

void Number(int m, int n)
{
    if (m <= n)
    {
        Console.Write(m); Number(m + 1, n);
    }
}

Console.WriteLine("Введите число от которого будт показаны все числа: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число до которого будт показаны все числа: ");
int m = int.Parse(Console.ReadLine());

Number(m, n);
Console.WriteLine();
