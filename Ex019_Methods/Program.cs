// Method 1

void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();

// Method 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg:"Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while ( i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}
Method21(msg:"Текст", count: 4);

// Method 3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Method 4

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);

// Method 5 FOR

string Method5(int count, string text)
{
    
    string result = string.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res1 = Method5(10, "z");
Console.WriteLine(res1);

// Method 6 ЦИКЛ В ЦИКЛЕ

for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j}={i*j}");
    }
    Console.WriteLine();
}

// Работа с тектом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большгие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty";
//             012345
//s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result1 = String.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result1 = result1 + $"{newValue}";
        else result1 = result1 + $"{text[i]}";
    }
    return result1;
}
string newText = Replace(text, ' ', '|');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'С', 'с');
System.Console.WriteLine(newText);


// РАБОТА С МАССИВОМ

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array) 
{
    int count = array.Length;
    for(int i = 0; i < count; i++) 
    {
        System.Console.Write($"{array[i]}");
    }
    System.Console.WriteLine();
}
void SelectionSort(int[] array)
{
    
    for(int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if ( array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);

//2
System.Console.WriteLine("наоборот");
int[] arr2 = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray2(int[] array2) 
{
    int count2 = array2.Length;
    for(int i = 0; i < count2; i++) 
    {
        System.Console.Write($"{array2[i]}");
    }
    System.Console.WriteLine();
}
void SelectionSort2(int[] array2)
{
    
    for(int i = 0; i < array2.Length -1; i++)
    {
        int minPosition2 = i;

        for(int j = i + 1; j < array2.Length; j++)
        {
            if ( array2[j] > array2[minPosition2]) minPosition2 = j;
        }

        int temporary2 = array2[i];
        array2[i] = array2[minPosition2];
        array2[minPosition2] = temporary2;
    }
}
PrintArray2(arr2);
SelectionSort2(arr2);

PrintArray2(arr2);