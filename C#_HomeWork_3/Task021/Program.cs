//   Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки А ,через запятую (x,y,z):  ");
string? strA = Console.ReadLine();
string[] arrA= strA.Split(",");
int[] strA1 = Array.ConvertAll(arrA, int.Parse);

Console.Write("Введите координаты точки B, через запятую (x,y,z):  ");
string? strB = Console.ReadLine();
string[] arrB= strB.Split(",");
int[] strB1 = Array.ConvertAll(arrB, int.Parse);

double s = Math.Sqrt(Math.Pow(strB1[0]-strA1[0],2) + Math.Pow(strB1[1]-strA1[1],2) + Math.Pow(strB1[2]-strA1[2],2));
//int z = (int)s;
Console.WriteLine("Расстояние между точками ->  " + Math.Round(s,2));
//Console.Write((int)s);