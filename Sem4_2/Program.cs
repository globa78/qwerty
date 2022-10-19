//System.Console.WriteLine("Введите число:");
//int count = int.Parse(Console.ReadLine());
//
//System.Console.WriteLine(GetLength(count));
//
//int GetLength(int count)
//{
//    int sum = 0;
//    while (true)
//    {
//        if (count == 0)
//        break;
//        count = count/10;
//        sum++;
//    }
//    return sum;
//}


System.Console.WriteLine("Введите число:");
string input = Console.ReadLine();
int count = int.Parse(input);

System.Console.WriteLine(GetLength(input));

int GetLength(string input)
{
    return input.Length;
}