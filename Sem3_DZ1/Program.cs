// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 
// 14212 -> нет
// 
// 12821 -> да
// 
// 23432 -> да
System.Console.Write("Введите полиандр:");
int number = int.Parse(Console.ReadLine());
string s = number.ToString();
if (s[0].ToString() == s[4].ToString() && s[1].ToString() == s[3].ToString())
{
    System.Console.WriteLine("да"); 
}
else
{
    System.Console.WriteLine("это не полиандр");
}
