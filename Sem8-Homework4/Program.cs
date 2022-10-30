// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника\

float Factorial(int n)
{
    float i, result = 1;
    for (i = 1; i < n; i++)
    {
        result *= i;
    }
    return result;
}


Console.Write("Введите количество строк треугольника: ");
int stroka = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
Console.WriteLine();



for (int i = 0; i < stroka; i++)
{
    for (int c = 0; c <= (stroka - i); c++)
    {
        Console.Write(" ");
    }
    for (int c = 0; c <= i; c++)
    {
        Console.Write(" ");
        Console.Write(Factorial(i) / (Factorial(c) * Factorial(i - c)));
    }
    Console.WriteLine();
}
Console.WriteLine(); 

