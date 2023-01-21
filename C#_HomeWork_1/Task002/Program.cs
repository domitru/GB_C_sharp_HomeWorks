/* Задача 2: Напишите программу,
             которая на вход принимает два числа и выдаёт,
            какое число большее, а какое меньшее.*/
            
Console.WriteLine("Сравнниваем два числа.");

Console.Write("Введите число A = ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B = ");
int B = Convert.ToInt32(Console.ReadLine());

if ( A > B )
{
    Console.WriteLine( "Максимальное число А = " + A);
    Console.WriteLine( "Минимальное  число B = " + B);
}
else if ( A == B )
{
    Console.WriteLine( "Два числа равны между собой");
}
else
{
    Console.WriteLine( "Максимальное число В = " + B);
    Console.WriteLine( "Минимальное  число А = " + A);
}
//  Ура!!! Это моя первая программа написанная самостоятельно.