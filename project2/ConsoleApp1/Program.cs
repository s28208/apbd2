// See https://aka.ms/new-console-template for more information


static double GetAverageNew(int[] numbers) {
    double suma = 0;
    foreach (var number in numbers)
    {
        suma += number;
    }
    return suma/numbers.Length;
}
int[] number = {1, 4, 3, 4};
double average = GetAverageNew(number);
Console.WriteLine(average);

