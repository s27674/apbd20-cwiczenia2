// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World1!");
Console.WriteLine("Modyfikacja2!");
Console.WriteLine("Modyfikacja3!");
Console.WriteLine("Meow");

static double GetAvg(int[] nums)
{
    double sum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        sum += nums[i];
    }

    return sum / nums.Length;
}

int[] nums = {1, 2, 3, 4};
double avrg = GetAvg(nums);
Console.WriteLine(avrg);
//zad4
static int GetMax(int[] numbers)
{
    int max = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}
int[] numbers = {2, 4, 5, 1, 7, 11, 3};
int max = GetMax(numbers);
Console.WriteLine(max);