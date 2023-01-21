/* Задача 8: Напишите программу, 
             которая на вход принимает число (N), 
             а на выходе показывает все чётные числа от 1 до N.
             5 -> 2, 4
             8 -> 2, 4, 6, 8
                                 */

Console.WriteLine("Введите число: ");
string? z = Console.ReadLine();
int a = Convert.ToInt32(z);
Console.Write(a + " -> ");
for (int i = 2; i < a-1; i=i+2)
{
    Console.Write( i + ", ");
}
if (0==a%2)
{
    Console.Write(a);
}
else
{
    Console.Write(a-1);
}

// //  Ура!!! Это моя четвертая программа написанная самостоятельно.