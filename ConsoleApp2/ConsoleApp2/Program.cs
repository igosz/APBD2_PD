Console.WriteLine("Hello, World!");
Console.WriteLine("Hellooooooooo 1");
Console.WriteLine("Hellooooooooo 2");
Console.WriteLine("Hellooooooooo 3");


static double Avg(int[] array)
{
    int suma = 0;
    foreach (int num in array)
    {
        suma += num;
    }
    return (double)suma/array.Length;
}


static int Max(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}