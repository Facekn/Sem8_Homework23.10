// Найти произведение двух матриц

void FillArray(int[,] array, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(min, max);
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}  ");
        Console.WriteLine();
    }
}
int[,] NewArray(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                result[i, j] += (array1[i, k]) * (array2[k, j]);
            }
        }

    }
    return result;
}

Console.Write("Введите число строк первого массива: ");
int m1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов первого массива: ");
int n1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число строк второго массива: ");
int m2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов второго массива: ");
int n2 = int.Parse(Console.ReadLine() ?? "0");
int[,] ArrayOne = new int[m1, n1];
int[,] ArrayTwo = new int[m2, n2];


FillArray(ArrayOne, 1, 10);
Console.WriteLine("Первый массив:");
PrintArray(ArrayOne);
Console.WriteLine();
FillArray(ArrayTwo, 1, 10);
Console.WriteLine("Второй массив:");
PrintArray(ArrayTwo);
Console.WriteLine();
if (n1 == m2)
{
    int[,] ArrayResult = NewArray(ArrayOne, ArrayTwo);
    Console.WriteLine("Произведение двух массивов: ");
    PrintArray(ArrayResult);
}
else Console.WriteLine("Количество столбцов одного массива не совпадает с колличеством строк другого массива");
