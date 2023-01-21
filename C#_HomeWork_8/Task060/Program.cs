// Задача 60. ...Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив,
//  добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



Console.Clear();
int[,,] matrix = new int [2, 2, 2];
int count = 10;
for (int i = 0; i < matrix.GetLength(0); i++)  
{
  for (int j = 0; j < matrix.GetLength(1); j++) 
  { 
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
      matrix[k, i, j] += count;
                count += new Random().Next(1,3);
              //count += 3;    
    }                                             
  }
}

for (int i = 0; i < matrix.GetLength(0); i++)  
{
  Console.Write("Матрица: " + (i + 1));
  for (int j = 0; j < matrix.GetLength(1); j++) 
  { 
    Console.WriteLine();
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
      Console.Write($"{matrix[i, j, k]} ({i},{j},{k})"+ " ");//Thread.Sleep(10);
    }                                             
    Console.WriteLine();
  }
  Console.WriteLine();
}
Console.WriteLine();


/*
Console.Clear();
System.Console.WriteLine("Введите колличество массивов: ");
int straniza = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int stroki = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int stolbzi = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int [straniza, stroki, stolbzi];

for (int i = 0; i < matrix.GetLength(0); i++)  
{
  for (int j = 0; j < matrix.GetLength(1); j++) 
  { 
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
      matrix[i, j, k] = new Random().Next(10,99); 
      
      Console.Write($"{matrix[i, j, k]} ({i},{j},{k})"+ " ");//Thread.Sleep(10);
    }                                             
    Console.WriteLine();
  }
  Console.WriteLine();
}
Console.WriteLine();
*/