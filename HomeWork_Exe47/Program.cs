// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите количество строк");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количство столбцов");
int column = int.Parse(Console.ReadLine());
double[,]matrix = new double[row, column];
for (int i=0; i<row; i++)
{
    for (int j=0; j< column; j++)
    {
        matrix[i,j] = new Random().NextDouble() * 10;
        Console.Write($"{Math.Round(matrix[i,j], 2)}, ");
    }
    Console.WriteLine();
}