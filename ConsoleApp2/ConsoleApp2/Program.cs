Console.WriteLine("Hello, World!");
Console.WriteLine("Hellooooooooo 1");
Console.WriteLine("Hellooooooooo 2");
Console.WriteLine("Hellooooooooo 3");


static double Avg(int[] array)
{
    int sum = 0;
    foreach (int num in array)
    {
        sum += num;
    }
    return (double)sum/array.Length;
}