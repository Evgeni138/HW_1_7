// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void FillArrayRandom(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

float Averege(int[,] array, int j)
{
    float averege = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        averege =  (float)array[i, j] + averege;  
    }
    return averege/array.GetLength(0);
}

int m,
    n;
Console.WriteLine("Введите количество строк (m):");
m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (n):");
n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArrayRandom(array, -9, 10);
PrintArray(array);
Console.WriteLine();

for (int i = 0; i < array.GetLength(1); i++)
{
    Console.Write(Averege(array, i) + " ");
}