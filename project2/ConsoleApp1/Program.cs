// See https://aka.ms/new-console-template for more information


static double GetAverage(int[] numbers) {
    double suma = 0;
    foreach (var number in numbers)
    {
        suma += number;
    }
    return suma/numbers.Length;
}
int[] numbers = {1, 2, 3, 4};
double average = GetAverage(numbers);
Console.WriteLine(average);