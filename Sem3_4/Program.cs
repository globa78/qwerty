System.Console.Write("Введите N:");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    System.Console.Write($" {Math.Pow(i,2)} ");
}

/*int n = int.Parse(Console.ReadLine());
double[] array = new double[n];

for (int i = 0; i < n; i++)
array[i] = Math.Pow(i + 1, 2);

foreach (double i in array)
Console.WriteLine(i)*/