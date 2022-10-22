// Expr2. Задается натуральное трехзначное число (гарантируется, что трехзначное). 
//Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.
//Задача выполнена для любого числа

int Number(string message)//Method tells to you input number
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Number("Input number to reverse");

double CalculationOfAnAMountOfDigits(int number)//Calculation of an amount of digits in input number
{
    double counter = 0;
    while(number > 0)
    {
        number = number / 10;
        counter++;
    }
    return counter;
}

int ReverseNumber(int number, double counter)//Reverse of the input number
{
    int temp = 0;
    int newNumber = 0;
    while (number > 0)
    {
        temp = number % 10;
        newNumber = newNumber + temp * (int)Math.Pow(10.0, counter-1);
        number = number / 10;
        counter--;
    }
    return newNumber;
}

int reversedNumber = ReverseNumber(number, CalculationOfAnAMountOfDigits(number));
Console.WriteLine($"After reversal {number} becomes {reversedNumber}");;