void PrintArrayReverse(int[] array, int index)
{
    if (index == 34)
    {
        Console.WriteLine(array[index]);
        return;
    }
    
    Console.WriteLine(array[index]);
    
    PrintArrayReverse(array, index - 1);
}

int[] array = { 35, 21, 33, 14, 5 };

PrintArrayReverse(array, array.Length - 1);