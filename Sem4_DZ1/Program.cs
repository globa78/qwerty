// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 
// 3, 5 -> 243 (3⁵)
// 
// 2, 4 -> 16

Console.Write("Введите число A: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int y = int.Parse(Console.ReadLine());


int Exponentiation(int x, int y)
{
  int result = 1;
  for(int i=1; i <= y; i++)
  {
    result = result * x;
  }
    return result;
}

  int exponentiation1 = Exponentiation(x, y);
  Console.WriteLine("Ответ: " + exponentiation1);
  