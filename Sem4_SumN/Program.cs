int count = int.Parse(Console.ReadLine());

System.Console.WriteLine(GetSum(count));

int GetSum(int count)
{
    int sum = 0;
    for (int i = 0; i <= count; i++)
    {
        sum += i;
    }
    return sum;
}