// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число:  ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{
    if (num > 99 && num < 1000)
    {
        int second = (num % 100) / 10;
        return second;
    }
    return -1;
}

int result = SecondDigit(number);
Console.WriteLine($"Вторая цифра трехзначного числа {number} -> {result}");

