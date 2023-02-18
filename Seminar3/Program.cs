// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных 
// координат точек в этой четверти (x и y).

/*
void ShowDiapazone (int quad)
{
    if (quad == 1) Console.WriteLine("x > 0 and Y > 0");
    else if (quad == 2) Console.WriteLine("x < 0 and Y > 0");
    else if (quad == 3) Console.WriteLine("x < 0 and Y < 0");
    else if (quad == 4) Console.WriteLine("x > 0 and Y < 0");
    else Console.WriteLine("Uncorrect input!");
}
Console.Write("Input a number of a quadrant: ");
int quadrant = Convert.ToInt32(Console.ReadLine());

ShowDiapazone(quadrant);
*/


// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
// номер четверти плоскости, в которой находится эта точка.

/*
int getQuarter (int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;

    return -1;
}

Console.Write("Введите координату x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = getQuarter(x, y);
if (quarter > 0)
    Console.WriteLine($"The point is in the {quarter} quater");
else
    Console.WriteLine($"The point is not in the quaters");
*/


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 2D пространстве.

/*
double getDistance(double xa, double ya, double xb, double yb)
{
    return Math.Sqrt((xb-xa) * (xb-xa) + (yb-ya) * (yb-ya));
}

Console.Write("Введите координату x первой точки: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");
double ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x второй точки: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");
double yb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ($"Расстояние между точками " + Math.Round(getDistance (xa, ya, xb, yb), 2));
*/


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

/*
void squareTable(int n)
{
    int currentNumber = 1;
    while(currentNumber <= n)
    {
        Console.WriteLine(currentNumber + "-" + (currentNumber * currentNumber));
        currentNumber++;
    }
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
    squareTable(n);
else
    Console.Write("Введите число больше 0: ");
*/