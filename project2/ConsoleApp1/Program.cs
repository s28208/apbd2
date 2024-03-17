// See https://aka.ms/new-console-template for more information

static int GetMax(int[] numbers)
{
    int max = numbers[0];
    foreach (var number in numbers)
    {
        if (max < number)
        {
            max = number;
        }
    }
    return max;
}
int[] numbers = {1, 4, 3, 1};
double max = GetMax(numbers);
Console.WriteLine(max);