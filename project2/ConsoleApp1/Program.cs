// See https://aka.ms/new-console-template for more information


static double GetAverage(int[] numbers) {
    double suma2 = 0;
    foreach (var number in numbers)
    {
        suma2 += number;
    }
    return suma2/numbers.Length;
}
int[] numbers = {1, 2, 3, 4};
double average = GetAverage(numbers);
Console.WriteLine(average);
Console.WriteLine("Konflikt");

