int[] array = new int[] {1,2,3,4,5,6,7,8,9,10};
System.Console.WriteLine(ArrayToString(array));
int[] newarray = TransporateArray(array);
System.Console.WriteLine(ArrayToString(newarray));
Transporate(array);
System.Console.WriteLine(ArrayToString(array));
string ArrayToString(int[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result+=$"{array[i]}, ";
    }
    return result;
}

int[] TransporateArray(int[] originArray)
{
    int[] newarray = new int[originArray.Length];
    for (int i = 0; i < originArray.Length; i++)
    {
        newarray[i] = originArray[originArray.Length-1-i];
    }
    return newarray;
}
void Transporate(int[] originArray)
{
    for (int i = 0; i < originArray.Length/2; i++)
    {
        int buffer = originArray[i];
        originArray[i] = originArray[originArray.Length - 1 - i];
        originArray[originArray.Length-1-i] = buffer;
    }
}