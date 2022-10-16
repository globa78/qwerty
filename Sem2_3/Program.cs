Console.WriteLine("Введите первое число:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int y = int.Parse(Console.ReadLine());
int n = x%y;
if (x % y == 0)
{
    Console.WriteLine("кратное");
}
else
{
    Console.WriteLine("не кратное, остаток:"+ n);
}

