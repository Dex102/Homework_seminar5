double[] NewArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 100, 1);
    }

    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}

double MinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    double diff;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }

    diff = max - min;

    return diff;
}

Console.Write("Input size of array: ");
int SizeArray = Convert.ToInt32(Console.ReadLine());

double[] MyArray = NewArray(SizeArray);
ShowArray(MyArray);

Console.Write("Difference is " + MinMax(MyArray));
