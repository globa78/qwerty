//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Введите число:");
int x = int.Parse(Console.ReadLine());
int count = x;
count = 0;
if (count<x && x % 2==0)
{
    while(count < x)
{
    count+=2;
    Console.WriteLine(count);
}
}
else 
{
    while(count < x)
{
    Console.WriteLine(count);
    count+=2;
}
}