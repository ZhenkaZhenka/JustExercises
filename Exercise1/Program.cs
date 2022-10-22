// Expr1. Как поменять местами значения двух переменных? Можно ли это сделать без ещё одной временной переменной. Стоит ли так делать?
//In C# language you can replace two variables each other only using one more temp variable. You have no choise.

int a = new Random().Next(0, 1000);
int b = new Random().Next(0, 1000);
Console.WriteLine($"a = {a}, b = {b}");

int temp = b;
b = a;
a = temp;
Console.WriteLine($"After replace the variables are a={a}, b={b}");