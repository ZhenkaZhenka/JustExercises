// Expr3. Задано время Н часов (ровно). Вычислить угол в градусах между часовой и минутной стрелками. 
// Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов. Не использовать циклы.

int hour = Number("Input Hour to calculate angle");

int Number(string message)//Method tells to you input number
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int ReCalculationOfHour(int number)//I've decided to recalculate input hour to 12th hour system
{
    if (number >12 ) return number-12;
    return number;
}

hour = ReCalculationOfHour(hour);//Get new type of hour;

int GetAngle(int number)
{
    if (number < 7) return number * 30;
    return 360 - number * 30;
}

Console.WriteLine($"Angle between the hands of clock is {GetAngle(hour)}");
