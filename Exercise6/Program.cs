// Expr6. Посчитать расстояние от точки до прямой, заданной двумя разными точками.
//Теорема косинусов- ее я использую для нахождения углов в образоваашемся треугольнике:
//a^2 = b^2 + c^2 -2bcCosA => cosA = (b^2+c^2-a^2)/ -2bc - где стороны b, c являются прилежащими углу катетами
// Формула нахождения рассояния==формуле высоты треугольника:
//    sin(a)+sin(b)
// ab---------------   -  где АВ- это расстояние между точками описыващих прямую, a,b-углы противолежащие высоте.
//     sin(a+b)


double ReadData(string message)
{
    Console.WriteLine(message);
    double number = (double)Convert.ToDouble(Console.ReadLine());
    return number;
}

double ax = ReadData("Введите координату X точки А");
double ay = ReadData("Введите координату Y точки А");
double bx = ReadData("Введите координату X точки B");
double by = ReadData("Введите координату Y точки B");
double mx = ReadData("Введите координату X точки M");
double my = ReadData("Введите координату Y точки M");

double LengthOfCathet(double ax, double ay, double bx, double by)
{
    return (double)Math.Sqrt(Math.Pow(bx-ax, 2) + Math.Pow(bx-ax, 2));
}

double lengthAB = LengthOfCathet(ax, ay, bx, by);
double lengthAM = LengthOfCathet(ax, ay, mx, my);
double lengthBM = LengthOfCathet(bx, by, mx, my);

double CalculationOfTheAngleOfTheTriangle(double a, double b, double c)//В описании метода b,c - прилежащие к углу катеты, а - противолежащий катет
{
    return Math.Cos((b*b+c*c-a*a)/-2*b*c);
}

double angleA = CalculationOfTheAngleOfTheTriangle(lengthBM, lengthAM, lengthAB);
double angleB = CalculationOfTheAngleOfTheTriangle(lengthAM, lengthAB, lengthBM);
double angleM = CalculationOfTheAngleOfTheTriangle(lengthAB, lengthAM, lengthBM);

double GetHeigth(double c, double gamma, double alfa)
{
    return c*((Math.Sin(alfa)+Math.Sin(gamma))/Math.Sin(alfa+gamma));
}

double Heigth = GetHeigth(lengthAB, angleA, angleB);

Console.WriteLine($"РАсстояние от точки М до прямой АВ равно {Heigth:f2}");