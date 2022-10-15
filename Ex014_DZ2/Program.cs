//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Введите первое число:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int z = int.Parse(Console.ReadLine());
int max = x;
if (x>max) max = x;
if (y>max) max = y;
if (z>max) max = z;
Console.Write("max = ");
Console.WriteLine(max);

