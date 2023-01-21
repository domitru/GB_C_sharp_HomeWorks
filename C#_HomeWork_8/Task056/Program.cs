// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку
//  с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и
//  выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int[,] matrix = new int [5, 4];
for (int i = 0; i < matrix.GetLength(0); i++)   
{
  for (int j = 0; j < matrix.GetLength(1); j++)  
  {                                              
    matrix[i, j] = new Random().Next(0,10); 
    Console.Write(matrix[i, j] + " ");
  }
  Console.WriteLine();
}
Console.WriteLine();

int s = 0;
int minsum = 0; 
int stroka = 0;
int e = 1;
for (int i = 0; i < matrix.GetLength(1); i++)
{
  minsum = minsum + matrix[0, i];
}
for (int i = 0; i < matrix.GetLength(0); i++)   
{
  for (int j = 0; j < matrix.GetLength(1); j++)  
  {                                              
    s = s + matrix[i, j];  
  }
  if (s < minsum)
  {
    minsum = s;
    stroka = i; 
  }
  Console.WriteLine($"Сумма {e} строки = " + s); 
  s=0; e++;
}
Console.WriteLine();
Console.WriteLine($"Минимальная сумма из строк: {minsum}");
Console.WriteLine($"Строка с наименьшей суммой элементов: {stroka + 1} строка.");
Console.WriteLine();