// Найти сумму цифр числа

int InputNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SplitNumber(int number)
{
    if(number == 0) return 0;
    else return number % 10 + SplitNumber(number / 10);
}


int number = InputNumber("Введите число, чтобы посчитать сумму цифр: ");
Console.WriteLine(SplitNumber(number));
