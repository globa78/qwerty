﻿Console.WriteLine("Введите первое число:");
int x = int.Parse(Console.ReadLine());

if (x % 7 == 0 && x % 23 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}