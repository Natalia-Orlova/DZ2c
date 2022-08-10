// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7: ");
int days = Convert.ToInt32(Console.ReadLine());

void Holiday (int day)
{
    if (day > 0 && day < 8)
{
    if (day == 6 || day == 7) Console.WriteLine($"{day} -> выходной");
    else
        Console.WriteLine($"{day} -> не выходной");
}
else
    Console.WriteLine($"цифра {day} не соответствует дню недели");
}

Holiday (days);
