double ReadData(string message)// В общем-то ты можешь не пользоваться методом ввода, а просто вводить число в ручную
{
    Console.WriteLine(message);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

double x = ReadData("Введите переменную Х");
double y = ReadData("Введите переменную Y");
double z = ReadData("Введите переменную Z");

double tanZ = Math.Tan(z);// Это выражение равно tgZ

double exp = Math.Exp(x-y);// Это выражение равно exp^(x-y)

double sqrtTanZ = Math.Pow(tanZ, 2);//Это выражение (tgZ)^2

double b = Math.Pow(sqrtTanZ + 1, x) * exp;// Math.Pow(sqrtTanZ + 1, x) == ((tgZ)^2 + 1)^x, где sqrtTan = (tgZ)^2

Console.WriteLine(b);