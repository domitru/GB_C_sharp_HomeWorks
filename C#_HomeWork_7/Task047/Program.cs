//Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
int rows = ReadInt("Введите колличество строк:  ");
int columns = ReadInt("Введите количество столбцов:  ");
double[,] numbers = new double[rows, columns];

int ReadInt(string message)    // Метод для ввода с консоли
{
  Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}

void FillMatrixRandomNumbers(double[,] array)  // метод для заполнения матрицы рандомными числами
                                            //  передает полученное в метод  WriteMatrix
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = //Math.Round((Convert.ToDouble(new Random().Next(-9, 9)) + new Random().NextDouble()),1);
                     // new Random().Next(-9, 9);
                    Math.Round(Convert.ToDouble(new Random().Next(-9, 9)*1.9),1);
    }
  }
}
FillMatrixRandomNumbers(numbers);  // Вызов метода и передача в него переменной из обработанной консоли

void WriteMatrix(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + "  ");
    }
    Console.WriteLine();
    Console.WriteLine();
  }
  Console.WriteLine();
  Console.WriteLine();
}
WriteMatrix(numbers);
