// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//             и возводит число A в натуральную степень B.
// пример:
//             3, 5 -> 243 (3⁵)
//              2, 4 -> 16

int NumPow (int A, int stepenB)         //  Метод ,число в степени.
{
   int i;
   int As = A*A;
   for (i = 2; i < stepenB; i++)
   As = As * A;
   return As;
}
int Vvod ( int out A, int out B )
{
   Console.Write("Ведите число А: ");
   int A = Convert.ToInt32(Console.ReadLine());
   Console.Write("Ведите число B: ");
   int stepenB = Convert.ToInt32(Console.ReadLine());
}
int result = NumPow(A, stepenB);        // Вызов метода число в степени.


Console.WriteLine(A + " в степени " + stepenB +" = " + result);




// Мы ведь можем написать в методе любые аргументы. 
// Например, Step(int num1, int num2).
//  А потом после функции Enter(out int A, out int B) 
//  использовать функцию метод Step(A, B) ?

