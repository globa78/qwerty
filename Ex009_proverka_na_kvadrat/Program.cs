Console.WriteLine("Введите первое число:");
string input1 = Console.ReadLine();
int x = int.Parse(input1);
Console.WriteLine("Введите второе число:");
string input2 = Console.ReadLine();
int y = int.Parse(input2);
if (x == y*y)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
