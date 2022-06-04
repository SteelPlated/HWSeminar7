/*Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.Write("Введите строку:");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;

Console.Write("Введите столбец:");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 4; int m = 3;
Random random = new Random();
int[,] array = new int[n, m];
Console.WriteLine();
void CreateArray(int[,] array)
{
        for (int i = 0; i < n; i++)
        {
        for (int j = 0; j < m; j++)
            {
            array[i, j] = random.Next(10, 99);
            Console.Write("{0} ", array[i, j]);
            }
        Console.WriteLine();
        }
}
void Search(int[,] array)
{
        if (pos1 < 0 | pos1 > n - 1 | pos2 < 0 | pos2 > m - 1)
        {
            Console.WriteLine("Такого элемента нет");
        }
        else
        {
            Console.WriteLine("Значение элемента массива = {0}", array[pos1, pos2]);
        }
}
CreateArray(array);
Search(array);