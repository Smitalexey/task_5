// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

void FillMassiv(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(100, 999);
    }         
}

void PrintMassiv(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{collection[i]}, ");
    }
    }

void CountMassiv(int[] collection)
{
    int length = collection.Length;
    int j = 0;
    for (int i = 0; i < length; i++)
    {
        if (collection[i] % 2 == 0)
        {
            j = j + 1;            
        }        
    }
    Console.WriteLine(j);
}         

Console.WriteLine();
Console.WriteLine("Задайте размерность массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Массив из {n} случайных чисел: ");
int[] massiv = new int[n];
FillMassiv(massiv);
PrintMassiv(massiv);
Console.WriteLine();
Console.WriteLine();
Console.Write("Количество четных чисел массива равно ");
CountMassiv(massiv);
Console.WriteLine();
