// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
//63
/*System.Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine());

void getNumbers(int N)
{
    if (N == 1)
    {
    System.Console.WriteLine(N);
    return;
    }
    else
    {
    
    getNumbers(N-1);    //от 1 до 5
    System.Console.WriteLine(N); 
    }
}
getNumbers(N);*/
//65
System.Console.Write("Введите N ");
int N = int.Parse(Console.ReadLine());
System.Console.Write("Введите M ");
int M = int.Parse(Console.ReadLine());

void getNumbersNM(int N, int M)
{
    if (M>=N)
    {
        if (M == N)
        {
        System.Console.WriteLine(M);
        return;
        }
        else
        {
        System.Console.WriteLine(M);
        M-=1;
        getNumbersNM(N,M);
        }
    }
    else System.Console.WriteLine($"{N}>{M} введите правильные данные");
}
getNumbersNM(N,M);