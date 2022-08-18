// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.

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
    
Console.WriteLine("Enter the coordinateesof the array element: ");

string positionElement = Console.ReadLine();
positionElement = RemovingSpaces(positionElement);
int[] position = ParserString(positionElement);

if(position[0] <= m && position[1] <= n && position[0] >= 0 
&& position[1] >= 0) 
{
  double result = matrix[position[0]-1, position[1]-1];
  Console.Write($"Result = {result}");
  Console.WriteLine();
}
else Console.Write($"There is no element");
Console.WriteLine();

int[] ParserString(string input)
{
  int countNumbers = 1;
  for (int i = 0; i < input.Length; i++)
  {
      if (input[i] == ',')
          countNumbers++;
  }

  int[] numbers = new int[countNumbers];

  int numberIndex = 0;
  for(int i = 0; i < input.Length; i++)
  {
    string subString = String.Empty;

    while (input[i] != ',')
    {
      subString += input[i].ToString();
      if (i >= input.Length - 1)
        break;
      i++;
    }
    numbers[numberIndex] = Convert.ToInt32(subString);
    numberIndex++;
  }

  return numbers;
}

string RemovingSpaces (string input)
{
  string output = String.Empty;
  for (int i = 0; i < input.Length; i++)
  {
    if (input[i] != ' ') 
    {
      output += input[i];
    }
  }
  return output;
}
