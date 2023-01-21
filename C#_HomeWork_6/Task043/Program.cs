// Задача 43: Напишите программу,                                
// которая найдёт точку пересечения двух прямых,                    
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;           
// значения b1, k1, b2 и k2 задаются пользователем.                                                                                  
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 

Console.Clear();
Console.Write("Введите значения первой прямой,через запятую (b1, k1):  ");
string? priamaj1 = Console.ReadLine();
string[] znach1 = priamaj1.Split(",");
double[] znacheniej1 = Array.ConvertAll(znach1, double.Parse);

Console.Write("\nВведите значения первой прямой,через запятую (b2, k2):  ");
string? priamaj2 = Console.ReadLine();
string[] znach2 = priamaj2.Split(",");
double[] znacheniej2 = Array.ConvertAll(znach2, double.Parse);

double b1 = znacheniej1[0];
double b2 = znacheniej2[0];
double k1 = znacheniej1[1];
double k2 = znacheniej2[1];
if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("\nПрямые совпадают.");
    }
else if (k1 == k2 && b1 != b2)
    {
        System.Console.WriteLine("\nПрямые параллельны.");
    }  
else 
    {     
        double x = Math.Round((b2 - b1) / (k1 - k2)   ,2);
        double y = Math.Round(k1 * x + b1   ,2);
        //double y = k1 * ( b2 - b1 ) / ( k1 - k2 ) + b1;
        Console.WriteLine("\nТочка пересечения двух прямых ( " + $"{x};{y}" + " )");
}
Console.WriteLine();
