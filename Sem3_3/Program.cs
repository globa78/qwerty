// ((x1-x2)^2 + (y1-y2)^2)
System.Console.Write("Введите Х1:");
int x1 = int.Parse(Console.ReadLine()); 

System.Console.Write("Введите Y1:");
int y1 = int.Parse(Console.ReadLine());

System.Console.Write("Введите Х2:");
int x2 = int.Parse(Console.ReadLine()); 

System.Console.Write("Введите Y2:");
int y2 = int.Parse(Console.ReadLine());

int [,] array  = new int [ 2 , 2 ];

array[0,0] = x1;
array[0,1] = y1;
array[1,0] = x2;
array[1,1] = y2;

double result = Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2));

System.Console.WriteLine($"Длина ={result}");
