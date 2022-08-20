void fillArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}


void printArray(int[] array)
{
    foreach (int element in array)
    {
        Console.Write(element+" ");
    }
}


int length = new Random().Next(5, 11);
int[] array = new int[length];
fillArray(array);
printArray(array);
int sum = 0;
for (int i=1; i<array.Length; i+=2)
{
    sum += array[i];
}
Console.WriteLine("\n"+sum);