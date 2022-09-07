// Написать программу вычисления функции Аккермана

static int FunctionAcker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return FunctionAcker(m - 1, 1);
    }
    else
    {
        return FunctionAcker(m - 1, FunctionAcker(m, n - 1));
    }
}

Console.WriteLine("Введите 1-e числоа: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2-e числоа: ");
int m = int.Parse(Console.ReadLine());

Console.Write(FunctionAcker(m, n));
