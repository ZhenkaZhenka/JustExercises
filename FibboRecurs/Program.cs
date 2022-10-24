// Посчитать число в ряду Фибонначи находящщееся на введенном порядковом номере. решение рекурсией.

int ReadData(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = ReadData("Input the last consequence digit of Fibbonachi number you want to see");
int counter = 0;

int Fibonnachi(int number)
{
    counter++;
    if (number == 0 || number == 1) return 1;
    return Fibonnachi(number - 2) + Fibonnachi(number - 1);
}


Console.WriteLine(Fibonnachi(number));
Console.WriteLine($"Program made {counter} itterations");