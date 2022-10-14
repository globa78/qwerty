Console.WriteLine("Введите число:");
int x = int.Parse(Console.ReadLine());
int count = x;
if (x<0)
{
    while (count < Math.Abs(x));
{
    Console.WriteLine(count);
    count++;
}
}
else
{
    count = - x;
    while(count < x)
{
    Console.WriteLine(count);
    count++;
}
}
Console.WriteLine(x);