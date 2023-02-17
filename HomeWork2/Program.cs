// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

/*
Console.Write("Input a positive three-digit number: ");
int InputNum = Convert.ToInt32(Console.ReadLine());
int result = InputNum / 10 % 10;

if (InputNum >= 100 && InputNum < 1000)
    Console.WriteLine($"Second digit of {InputNum} is {result}");
else 
    Console.Write("You did input not a positive three-digit number");
*/


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

/*
Console.Write("Input a number of the day of the week: ");
int Weekday = Convert.ToInt32(Console.ReadLine());

if(Weekday <= 7 && Weekday != 0)
    if(Weekday <= 5)
    Console.WriteLine("No, it's a workday :(");
    else
    Console.WriteLine("Yes, it's the weekend!");
else
Console.WriteLine("Inputed number does not indicate the day of the week, use numbers from 1 to 7");    
*/


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*
Console.Write("Input a positive number: ");
int InputNum = Convert.ToInt32(Console.ReadLine());
string InputNumText = Convert.ToString(InputNum);

if (InputNumText.Length > 2)
Console.Write($"Third digit of the number {InputNum} is " + InputNumText[2]);
else
Console.Write($"Third digit of the number {InputNum} is missing");
*/