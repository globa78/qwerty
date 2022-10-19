// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 
// 452 -> 11
// 
// 82 -> 10
// 
// 9012 -> 12

// Console.Write("Введите число A: ");
// int x = int.Parse(Console.ReadLine());
// 
// int SumNumber(int x)
//   {
//     
//     int counter = Convert.ToString(x).Length;
//     int advance = 0;
//     int result = 0;
// 
//     for (int i = 0; i < counter; i++){
//       advance = x - x % 10;
//       result = result + (x - advance);
//       x = x / 10;
//     }
//    return result;
//   }
// 
// int sumNumber = SumNumber(x);
// Console.WriteLine("Сумма цифр в числе: " + sumNumber);

Console.Write("Введите число A: ");
int x = int.Parse(Console.ReadLine());
int counter = Convert.ToString(x).Length;
int advance = 0;
int result = 0;

for (int i = 0; i < counter; i++)
{
    advance = x - x % 10;
    result = result + (x - advance);
    x = x / 10;
}  
System.Console.WriteLine(result);
