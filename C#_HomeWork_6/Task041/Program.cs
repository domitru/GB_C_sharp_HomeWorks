
// Задача 41: Пользователь вводит с клавиатуры M чисел.            
// Посчитайте, сколько чисел больше 0 ввёл пользователь.           
// 0, 7, 8, -2, -2 -> 2                                           
// 1, -7, 567, 89, 223-> 3 

Console.Clear();
string[] PrinimaemChisla()                            
{
    Console.WriteLine("Введите через запятую несколько разных чисел: ");
    string? strA = Console.ReadLine();  
    string[] arrA= strA.Split(",");                                     
    Console.WriteLine("\nМассив:[ {0}" + " ]",String.Join( " | ",arrA));                                                           
    return arrA;
}
string[] massiv = PrinimaemChisla();

double[] strA1 = Array.ConvertAll(massiv,double.Parse);
int g = massiv.Length;
Console.WriteLine("\nКолличество чисел в массиве: " + g);
int Kollichestvo = 0;
for(int i = 0; i < massiv.Length;i++)
{
    if (strA1[i] > 0)
    {
        Kollichestvo++; 
    }
}
Console.WriteLine("Колличество чисел больше нуля = " + Kollichestvo);
// еще вариант решения задачи
/*
Console.Clear();
Console.WriteLine($"Задача 41. Cколько чисел больше 0 ввёл пользователь \n");
Console.Write($"Введи число M(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
 Console.Write($"Введи {i+1} число: ");
 massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}
InputNumbers(m);
Console.WriteLine($"Колличество чисел больше нуля : {Comparison(massiveNumbers)} ");
*/