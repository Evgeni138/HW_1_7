// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


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

int x,
    y;
Console.WriteLine($"Введите строку нужного элемента от 0 до {n-1} (x):");
x = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите столбец нужного элемента от 0 до {m-1} (y):");
y = int.Parse(Console.ReadLine());

if ( x < n && y < m && x >= 0 && y >= 0) Console.WriteLine(array[x, y]);
else Console.WriteLine("Такого элемента не существует");
