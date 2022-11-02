// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

//Доп. Факториал


//67
/*System.Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine());

int GetSumNumbers(int N)
{
    if (N / 10 == 0)
    {
        return N;
    }
    else
    {
    return GetSumNumbers(N/10) + N%10;
    
    }
}
System.Console.WriteLine(GetSumNumbers(N));*/

//69
/*System.Console.Write("Введите A ");
int A = int.Parse(Console.ReadLine());
System.Console.Write("Введите B ");
int B = int.Parse(Console.ReadLine());

int GetPowAB(int A, int B)
{
    if (B == 1)
    {
        return A;
    }
    else
    {
        return GetPowAB(A,B-1)*A;
    }
    
}
System.Console.WriteLine(GetPowAB(A,B));*/

//Доп
System.Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine());

int GetFactorial(int N)
{
    if (N == 1)
    {
        return 1;
    }
    else
    {
    return GetFactorial(N-1)*N;
    
    }
}
System.Console.WriteLine(GetFactorial(N));