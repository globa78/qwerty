System.Console.Write("Введите номер четверти:");
int number = int.Parse(Console.ReadLine()); 

int [,] array  = new int [ 4 , 2 ];

array[0,0] = 1;
array[0,1] = 1;

array[1,0] = -1;
array[1,1] = 1;

array[2,0] = -1;
array[2,1] = -1;

array[3,0] = 1;
array[3,1] = -1;

int x = 0;
int y = 0;

    int minx = array[number -1, 0];
    int miny = array[number -1, 1];
    string maxx = "";
    string maxy = "";
    if (minx>0)
{
    maxx = "бесконечность";
}
else
{
    maxx = "-бесконечность";
}
if (miny>0)
{
    maxy = "бесконечность";
}
else 
{
    maxy = "-бесконечность";
}
    System.Console.WriteLine($"от x = {minx} до x = {maxx}");
    System.Console.WriteLine($"от y = {miny} до y = {maxy}");
    
//  System.Console.Write("Введите номер четверти:");
//  int x = int.Parse(Console.ReadLine()); 
//  
//  int [,] array  = new int [ 4 , 5 ];
//  
//  array[0,1] = 1;
//  array[0,2] = int.MaxValue;
//  array[0,3] = 1; 
//  array[0,4] = int.MaxValue;
//  
//  array[1,1] = -1;
//  array[1,2] = int.MinValue;
//  array[1,3] = 1;
//  array[1,4] = int.MaxValue;
//  
//  array[2,1] = -1;
//  array[2,2] = int.MinValue;
//  array[2,3] = -1;
//  array[2,4] = int.MinValue;
//  
//  array[3,1] = 1;
//  array[3,2] = int.MaxValue;
//  array[3,3] = -1;
//  array[3,4] = int.MinValue;
//  
//  
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
     // array[i,0] = i + 1;
     // System.Console.Write(array[x-1, i]);
//  }