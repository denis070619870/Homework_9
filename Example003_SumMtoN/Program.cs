//Найти сумму элементов от M до N, N и M заданы

int SumNumber(int m, int n)
{
    if (n == m) return m;
    else return n + SumNumber (n - 1, m);
}

Console.WriteLine("Введите число от которого будт показаны все числа: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число до которого будт показаны все числа: ");
int n = int.Parse(Console.ReadLine());

SumNumber(m, n);
Console.WriteLine(SumNumber(m, n));
