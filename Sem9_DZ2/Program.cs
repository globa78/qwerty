// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// 
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
System.Console.Write("Введите A ");
int A = int.Parse(Console.ReadLine());
System.Console.Write("Введите B ");
int B = int.Parse(Console.ReadLine());

int GetPowAB(int A, int B)
{
    if (B == A)
    {
        return A;
    }
    else
    {
        return GetPowAB(A,B-1)+B;
    }
    
}
System.Console.WriteLine(GetPowAB(A,B));
