// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов 
// в каждом столбце.

Console.Write("Enter n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter m = ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(-10,10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
    }
    Console.WriteLine();
    
    for (int i = 0; i < n; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < m; j++)
  {
    arithmeticMean += matrix[j, i];
  }
  arithmeticMean = Math.Round(arithmeticMean / m, 1);
  Console.WriteLine($"Column № {i+1} {arithmeticMean}");
}
