void FillMassiv(double[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(0, 1000);
    }
}

void PrdoubleMassiv(double[] collection)
{
    
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"{collection[i]}, ");
    }
}

void DifferenceMassiv(double[] collection)
{
    double maxСollection = collection[0];
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] > maxСollection) maxСollection = collection[i];
    }
    Console.WriteLine("Максимальное число массива: ");
    Console.WriteLine(maxСollection);

    double minСollection = collection[0];
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] < minСollection) minСollection = collection[i];
    }
    Console.WriteLine("Минимальное число массива: ");
    Console.WriteLine(minСollection);
    Console.WriteLine("Разница между максимальным и минимальными числами массива равна ");
    Console.WriteLine(maxСollection - minСollection);
}

Console.WriteLine("Введите любое натуральное число  ");
int n = Convert.ToInt32(Console.ReadLine());
double[] massiv = new double[n];
Console.WriteLine();
Console.WriteLine($"Массив из {n} элементов: ");
FillMassiv(massiv);
PrdoubleMassiv(massiv);
Console.WriteLine();
DifferenceMassiv(massiv);
Console.WriteLine();
