// Задача 50. Напишите программу,
//  которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4     17 -> такого числа в массиве нет


Console.Clear();
int rows = ReadInt("Введите колличество строк:  ");
int columns = ReadInt("Введите количество столбцов:  ");
int[,] numbers = new int[rows, columns];

int ReadInt(string message)
{
  Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}

void WriteMatrix(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}
WriteMatrix(numbers);

Console.Write("Введите позицию строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (row < rows & column < columns)
{   Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Цифра по этим позициям: ->  " + numbers[row, column]);
    Console.ForegroundColor = ConsoleColor.Gray;}
else Console.WriteLine("Ой, такого номера нет !");

for(int i = 0; i < rows; i++)
{
    for(int j = 0; j < columns; j++)
    {
        if (i == row & j == column) Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(numbers[i,j] + " ");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    Console.WriteLine();
}