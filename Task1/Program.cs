void fillArray(int[] array)
{
    int x = 0;
    for (int i=0; i<array.Length; i++)
    {
        x = new Random().Next(100, 1000);
        array[i] = x;
    }
}


void printArray(int[] array)
{
    foreach (int element in array)
    {
        Console.Write(element+" ");
    }
}


int length =  new Random().Next(5,11);
int[] array = new int[length];
fillArray(array);
printArray(array);
int count = 0;
foreach (int element in array)
{
    if (element % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine("\n"+count);