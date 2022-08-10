// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число:  ");
int number = Convert.ToInt32(Console.ReadLine());

void SecondDigit(int num)
{
    if (num < 0) num = num * (-1);
    if (num > 99 && num < 1000)
    {
        int second = (num % 100) / 10;
        Console.WriteLine($"Вторая цифра указанного числа -> {second}");
    }
    else
        Console.WriteLine("Введенное число не трехзначное, повторите попытку");
}

SecondDigit(number);


