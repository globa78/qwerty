// Random rnd = new Random();

// int  number = (int)rnd.NextInt64(100,999);
// Console.WriteLine(number);
// int firstNumber = 0;
// int secondNumber = 0;
// 
// firstNumber = number/100;
// secondNumber = number % 10;
// Console.WriteLine(firstNumber*10 + secondNumber);

int number = new Random().Next(100,999);
string s = number.ToString();
Console.WriteLine(s);
Console.WriteLine(s[0].ToString() + s[2].ToString());
