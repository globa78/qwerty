// System.Console.WriteLine("Введите число:");
// int number = int.Parse(Console.ReadLine());
// 
// System.Console.WriteLine(GetF(number));
// 
// int GetF(int number)
// {
//     int F = 1;
//     for (int i = 1; i <= number ; i++)
//     {
//         F = F*i;
//     }
//     return F;
// }

int number = int.Parse(Console.ReadLine());
System.Console.WriteLine(GetF(number));

int GetF(int number)
{
    if ( number <=1)
    return 1;
    return number * GetF(number - 1);
}