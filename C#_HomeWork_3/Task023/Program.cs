// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число: ");
// int numconsole = Convert.ToInt32(Console.ReadLine());
// int a = 0;
// for (int i=1; i<=numconsole; i++) 
//     {a = i * i * i;

//      Console.Write(a + "  ");}


Console.WriteLine("Введите число: ");
int numconsole = Convert.ToInt32(Console.ReadLine());

for (int i=1; i<=numconsole; i++) 
    Console.Write(i*i*i + "  ");