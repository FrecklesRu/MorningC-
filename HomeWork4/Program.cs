// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
int RaiseToAPower (int a, int b)
{
    int result = 1;

    for(int i = 1; i <= b; i++)
    {
        result *= a;
    }
        
    return result;
}

Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = RaiseToAPower(a, b);
Console.WriteLine($"The number {a} in the power {b} is {result}");
*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
int SumOfDigits(int num)
{
    int result = 0;
    
    while(num > 0)
    {
        result = result + (num % 10);
        num = num / 10;
    }
    return result;
}

Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumOfDigits(number);

Console.WriteLine($"The sum of digits in a number {number} is {sum}");
*/


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*
int[] NewArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) 
    {
        Console.Write("Input a numbers: ");
        int numbers = Convert.ToInt32(Console.ReadLine());
        array[i] = numbers;
    }
    return array;
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = NewArray(size);
Console.WriteLine($"Generating an array of {size} elements: [{String.Join(", ", array)}]");
*/