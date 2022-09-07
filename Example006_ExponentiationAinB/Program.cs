//Написать программу возведения числа А в целую стень B

int Exponentiation(int m, int n)
{
    if (n == 1) return m;
    else return m * Exponentiation(m, n - 1);
}

Console.WriteLine("Введите число: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int n = int.Parse(Console.ReadLine());

Exponentiation(m, n);
Console.WriteLine(Exponentiation(m, n));