// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void ThirdDigit(int number)
{
    if (number < 0) number = number * (-1);
    if (number < 100)
        Console.WriteLine($"В указанном числе нет 3-й цифры");
    else
    {
        while (number > 999)
        {
            number = number / 10;
        }
        Console.WriteLine($"Третья цифра указанного числа: {number % 10} ");
    }
}

ThirdDigit (num);