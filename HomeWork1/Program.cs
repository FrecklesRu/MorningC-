// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/*
Console.Write("Input a first number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int numB = Convert.ToInt32(Console.ReadLine());

int max = numA;
int min = numB;

if(numA > numB)
{
    max = numA;
    min = numB;
}
else
{
    max = numB;
    min = numA;
}
Console.WriteLine("Max number is: " + max);
Console.WriteLine("Min number is: " + min);
*/


// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

/*
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(max < num2)
    max = num2;
if(max < num3)
    max = num3;

Console.Write("Max number is " + max);
*/


// Задача 6: Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

/*
Console.WriteLine("Is the number even?");
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 !=0)
{
    Console.WriteLine("No");
    }
else
{
    Console.WriteLine("Yes");
}
*/


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

/*
Console.Write("Input a positiv number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;
int step = 2;

while(current <= num)
{
    Console.Write(current + " ");
    current = current + step;
}
if(num <= 0)
{
    Console.Write("Input error!");
}
if(num == 1)
{
    Console.Write("The entered number must be greater than " + num + "!");
}
*/