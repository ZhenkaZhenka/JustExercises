// Expr5. Найти количество високосных лет на отрезке [a, b] не используя циклы.

int ReadData(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int a = ReadData("Input start year for calculation");
int b = ReadData("Input second year for calculation");

int CalculationOfAnAmountOfTheLeapYears(int a, int b)
{
    return (b - a) / 4 + 1;
}

int amountOfYears = CalculationOfAnAmountOfTheLeapYears(a,b);
Console.WriteLine($"Amount of the leap years on the row from {a} to {b} is {amountOfYears}");