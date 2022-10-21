int[] CreateArray(int size, int minvalue, int maxvalue)
{
    int [] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minvalue, maxvalue);
    }
    return array;
}
int GetSumPositiveElementsFromArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) sum = sum + array[i];
    }
    return sum;
}

int GetSumNegativeElementsFromArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<0) sum = sum + array[i];
    }
    return sum;
}

string GetArray(int[] array)
{
    string sum = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + $"{array[i]}, ";
    }
    return sum;
}

int[] array = CreateArray(12,-9,10);

System.Console.WriteLine(GetArray(array));
System.Console.WriteLine("Cумма положительных элементов равна:" + GetSumPositiveElementsFromArray(array));
System.Console.WriteLine("Cумма положительных элементов равна:" + GetSumNegativeElementsFromArray(array));  

