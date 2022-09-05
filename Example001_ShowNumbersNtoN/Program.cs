// Показать натуральные числа от N до 1, N задано


void ShowNumber(int n, int m)
{
    if (n >= m)
    {
        Console.WriteLine($"{n} "); ShowNumber(n - 1, m);        
    }
}

Console.WriteLine("Введите число от которого нужно показать отсчет: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Показать обратный отсчет от: {n} ");
int m = 1;
ShowNumber(n, m);
Console.WriteLine();
