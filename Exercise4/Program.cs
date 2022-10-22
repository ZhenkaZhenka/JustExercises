// Expr4. Найти количество чисел меньших N, которые имеют простые делители X или Y.

int Number(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int n = Number("Input natural number");
int x = Number("Input forst prime divisor");
int y = Number("Input second prime divisor");

int CalculationOfTheAmountOfNumbers(int n, int x, int y)
{
    int counter = 0;
    for (int i = 1; i < n; i++)
    {
        if (i%x == 0 || i%y == 0)
        {
            counter++;
            Console.Write($"{i} ");
        }
    }
    return counter;
}

int result = CalculationOfTheAmountOfNumbers(n, x, y);

Console.WriteLine($"The Amount of numbers that sutisfied condition of the exercise is {result}");
