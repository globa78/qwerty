//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
string s = number.ToString();
if ( number > 99)
{
    Console.WriteLine(s[2].ToString());
}
else 
{
    Console.WriteLine("третьей цифры нет");
}

