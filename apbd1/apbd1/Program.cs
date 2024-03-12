// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World1!");
Console.WriteLine("Modyfikacja2!");
Console.WriteLine("Modyfikacja3!");

static double GetAverage(int[] nums)
{
    double sum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        sum += nums[i];
    }

    return sum / nums.Length;
}