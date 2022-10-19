// Задача 21
// 
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// 
// A (3,6,8); B (2,1,-7), -> 15.84
// 
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.Write("Введите Х1:");
int x1 = int.Parse(Console.ReadLine()); 

System.Console.Write("Введите Y1:");
int y1 = int.Parse(Console.ReadLine());

System.Console.Write("Введите Z1:");
int z1 = int.Parse(Console.ReadLine()); 

System.Console.Write("Введите X2:");
int x2 = int.Parse(Console.ReadLine());

System.Console.Write("Введите Y2:");
int y2 = int.Parse(Console.ReadLine()); 

System.Console.Write("Введите Z2:");
int z2 = int.Parse(Console.ReadLine());

int [,] array  = new int [ 2 , 3 ];

array[0,0] = x1;
array[0,1] = y1;
array[1,0] = x2;
array[1,1] = y2;
array[1,0] = z1;
array[0,1] = z2;

double result = Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2) + Math.Pow((z1 - z2),2));

System.Console.WriteLine($"Длина ={result}");