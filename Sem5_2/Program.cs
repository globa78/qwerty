//    int[] CreateArray(int size, int minvalue, int maxvalue)
//    {
//        int [] array = new int[size];
//        Random random = new Random();
//        for (int i = 0; i < array.Length; i++)
//        {
//            array[i] = random.Next(minvalue, maxvalue);
//        }
//        return array;
//    }
//    
//    int[] changeznak(int[] array)
//    {
//        for (int i = 0; i < array.Length; i++)
//        {
//            array[i] = -array[i];
//            return array;
//        }
//    }
//    
//    int[] vivodMassiva(int[] array)
//    {
//        for (int i = 0; i < array.Length; i++)
//        {
//            System.Console.WriteLine(array[i]);
//            return array;
//        }
//    }
//    System.Console.WriteLine("Введите кол-во эл-ов массива:");
//    int size = int.Parse(Console.ReadLine());
//    System.Console.WriteLine("Введите начальное значение массива:");
//    int minvalue = int.Parse(Console.ReadLine());
//    System.Console.WriteLine("Введите конечное значение массива:");
//    int maxvalue = int.Parse(Console.ReadLine());
//    
//    vivodMassiva(CreateArray(size,minvalue,maxvalue));

int[] CreateArray(int size, int min, int max)
{
int[] array = new int[size];
Random rnd = new Random();

for (int i = 0; i < size; i++)
{
array[i] = rnd.Next(min, max);
}

return array;
}


int[] GetReverseArray(int[] array)
{
int[] reversedArray = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
reversedArray[i] = -array[i];
}

return reversedArray;
}



string ArrayToString(int[] array)
{
string result = "[";

foreach (int item in array)
{
result += $"{item}, ";
}

result.Trim(',');
result += "]";

return result;
}



int[] array = CreateArray(10, -10, 10);

Console.WriteLine(ArrayToString(array));
Console.WriteLine(ArrayToString(GetReverseArray(array)));
