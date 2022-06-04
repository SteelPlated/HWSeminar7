/*Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого
столбца: 4,6; 5,6; 3,6; 3.*/
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"m = {m}, n = {n}.");
int[,] array = new int[m, n];
Random random = new Random();



void Calculations(int[,] array)
{
Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
  double Mean = 0;
  for (int j = 0; j < m; j++)
  {
    Mean += array[j, i];
  }
  Mean = Math.Round(Mean / m, 1);
  Console.WriteLine($"столбца № {i+1} {Mean}");
}
}


void CreateArray(int[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.Next(1, 99);
    }
  }
}

void PrintArray (int[,] array){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        Console.Write(array[i, j] + " ");
      }
      Console.WriteLine();
  }
}
CreateArray(array);
PrintArray(array);
Calculations(array);