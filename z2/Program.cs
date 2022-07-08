int[] NewArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 1000);
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

int SumEvenPos(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }

    return sum;
}

Console.Write("Input size of array: ");
int SizeArray = Convert.ToInt32(Console.ReadLine());

int[] MyArray = NewArray(SizeArray);
ShowArray(MyArray);

Console.Write("Sum of elements is " + SumEvenPos(MyArray));