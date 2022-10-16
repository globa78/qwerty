Random rnd = new Random();

int  number = (int)rnd.NextInt64(10,99);
Console.WriteLine(number);
int firstNumber = 0;
int secondNumber = 0;

firstNumber = number/10;
secondNumber = number % 10;
if (firstNumber>secondNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(secondNumber);
}