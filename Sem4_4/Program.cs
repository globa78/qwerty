Massiv();
void Massiv()
{
    int[] N = new int [8];
    System.Console.Write("Массив:[");

    for (int i = 0; i < N.Length; i++)
    {
        N[i] = new Random().Next(0,2);
        System.Console.Write($"{N[i]} ");
    }
    System.Console.Write("]");
}