/* Задача 4: Напишите программу,
             которая принимает на вход три числа
             и выдаёт максимальное из этих чисел.*/

Console.WriteLine("Сравниваем три числа между собой.");

Console.Write("Введите первое число: ");
int A= Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int C = Convert.ToInt32(Console.ReadLine());

if  ((A == B)&&(B==C))
 {
     Console.WriteLine("Все числа равны между собой.Максимального нет.");
 }
 else if ((A > B)&&(A > C))
 {
     Console.WriteLine("Максимальное число: " + A);
 }
 else if (B > C)
 {
     Console.WriteLine("Максимальное число: " + B);
}
 else 
  {
        Console.WriteLine("Максимальное число: " + C);
  }
// //  Ура!!! Это моя вторая программа написанная самостоятельно.