// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1
// Если N = 5 -> 0 1 1 2 
// Если N = 3 -> 0 1 
// Если N = 7 -> 0 1 1 2 3 5 8


Console.WriteLine("Enter your number: ");
int n = int.Parse(Console.ReadLine());
int [] array = Fb (n);
PrintArray (array);

void PrintArray(int[] array)
{
int count = array.Length;

for (int i = 0; i < count; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}


int [] Fb (int n)
{
int [] array = new int [n];
array [0] = 0;
array [1] = 1;
for (int i = 2; i < array.Length ; i++)
{
array [i] = array [i-1] + array [i-2];


}
return array;

}
/*
int[] CreateEmptyArrayForFibbonachi(int size)
{
int[] array = new int[size];

array[0] = 0;
array[1] = 1;

return array;
}

string ArrayToString(int[] array)
{
string result = string.Empty;

for (int i = 0; i < array.Length; i++)
{
result += array[i] + " ";
}

return result;
}

int[] GetFibonachi(int[] emptyArray)
{
for (int i = 2; i < emptyArray.Length; i++)
{
emptyArray[i] = emptyArray[i - 1] + emptyArray[i - 2];
}

return emptyArray;
}

int[] fib = CreateEmptyArrayForFibbonachi(8);
fib = GetFibonachi(fib);
Console.WriteLine(ArrayToString(fib));*/