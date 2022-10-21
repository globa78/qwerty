﻿int[] CreateArray(int size, int min, int max)
{
int[] array = new int[size];
Random rnd = new Random();

for (int i = 0; i < size; i++)
{
    array[i] = rnd.Next(min, max);
}
 
return array;
}

int Qelements(int[] array)
{
    int counter = 0;
    foreach (int element in array)
    {
        if (element >9 && element <99)counter++; 
    }
    return counter;
}

string GetArray(int[] array) // функиця перевод массива в строку
{
    string sum = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + $"{array[i]}, ";
    }
    return sum;
}

int[] array = CreateArray(123, -150, 150);
System.Console.WriteLine(GetArray(array));
System.Console.WriteLine(Qelements(array));

int[] ProzElem(int[] array)
{
    int[] arrayP = new int[array.Length/2+1];
    int i;
    for (i=0; i < array.Length/2; i++)
    {
        arrayP[i] = array[i]*array[array.Length-i-1];
    }
    if(array.Length%2 !=0)arrayP[arrayP.Length-1] = array[i];
    return arrayP;
}
array = CreateArray(5, 0, 10);
System.Console.WriteLine(GetArray(array));
System.Console.WriteLine(GetArray(ProzElem(array)));