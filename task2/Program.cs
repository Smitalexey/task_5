// // - Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечетных позициях.

void FillMassiv(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(0, 1000);
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

void SumMassiv(int[] collection)
{
    int rez = 0;
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 == 0)
            {
               rez = rez + collection[i];
            }
    } 
    Console.Write(rez);        
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
Console.Write("Сумма элементов на нечетных позициях равна ");
SumMassiv(massiv);
Console.WriteLine();
