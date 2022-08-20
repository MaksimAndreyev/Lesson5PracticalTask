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
int max = array[0];
int min = array[1];
foreach (int element in array)
{
    if (element > max)
    {
        max = element;
    }
    else if (element < min)
    {
        min = element;
    }
}
Console.WriteLine("\n"+(max-min));