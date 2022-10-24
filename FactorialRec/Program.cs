//Посчитать факториал введенного числа, используя рекурсию

int ReadData(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = ReadData("Input number for calculation > 0");

long Factorial(int number)
{
    Console.WriteLine($"Itteration {number}");
    if(number == 1) return 1;
    return number * Factorial(number -1);
}

long calculatedFactorial = Factorial(number);

Console.WriteLine($"Factorial of {number} is {calculatedFactorial}");
