int[] NewArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}

int CountOdd(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }

    return count;
}

Console.Write("Input size of array: ");
int SizeArray = Convert.ToInt32(Console.ReadLine());

int[] MyArray = NewArray(SizeArray);
ShowArray(MyArray);

Console.Write("Count of odd elemnts is: " + CountOdd(MyArray));


