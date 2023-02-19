// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
void Palindrome(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
        Console.WriteLine($"Number {number} is a palindrome");
    else
        Console.WriteLine($"Number {number} is not a palindrome");
}
Console.WriteLine("Input a number for checking: ");
string number = Convert.ToString(Console.ReadLine());
if (number.Length == 5)
    Palindrome(number);
else
    Console.WriteLine($"Wrong number. Input a five-digit number");
*/


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double getDistance3D (double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Sqrt((xb-xa) * (xb-xa) + (yb-ya) * (yb-ya) + (zb-za) * (zb-za));
}
Console.Write("Введите координату x первой точки: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z первой точки: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x второй точки: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z второй точки: ");
double zb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ($"Расстояние между точками " + Math.Round(getDistance3D(xa, ya, za, xb, yb, zb), 2));
*/


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/*
void cubeTable (int n)
{
    int currentNumber = 1;
    while (currentNumber <= n)
    {
        Console.WriteLine(currentNumber + " - " + Math.Pow(currentNumber, 3));
        currentNumber++;
    }
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
    cubeTable(n);
else
    Console.Write("Введите число больше 0: ");
*/