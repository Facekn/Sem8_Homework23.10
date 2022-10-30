// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

void FillArray(int[,] massiv)
{
    Random random = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = random.Next(1, 20);
        }
    }
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[] MinRowColOperation(int[,] array)
{
    int[] numbers = new int[2];
    int minNumber = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minNumber)
            {
                minNumber = array[i, j];
                numbers[0] = i;
                numbers[1] = j;
            }
        }
    }
    return numbers;
}
void PrintNewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"   {array[i] + 1}      ");
    }
}
int[,] Remote(int[,] matrix, int[] array)
{
    int[,] matrix2 = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            if (i < array[0]) matrix2[i, j] = matrix[i, j];
            else matrix2[i, j] = matrix[i + 1, j];
        }
    }
    int[,] resultArray = new int[matrix2.GetLength(0), matrix2.GetLength(1) - 1];
    {
        for (int i = 0; i < resultArray.GetLength(0); i++)
        {
            for (int j = 0; j < resultArray.GetLength(1); j++)
            {
                if (j < array[1]) resultArray[i, j] = matrix2[i, j];
                else resultArray[i, j] = matrix2[i, j + 1];
            }
        }
    }
    return resultArray;
}


Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбов: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
int[] minPosition = MinRowColOperation(array);
Console.WriteLine();
Console.WriteLine("Позиция минимального числа: ");
Console.WriteLine("Строка    Столбец");
PrintNewArray(minPosition);
Console.WriteLine();
int[,] newMatrix = Remote(array, minPosition);
Console.WriteLine("Получившийся массив: ");
PrintArray(newMatrix);
