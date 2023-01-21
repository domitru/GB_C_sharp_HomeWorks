// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// пример:
//             1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//             6, 1, 33 -> [6, 1, 33]
/*
int [] mas = new int [8];

for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new Random().Next(0, 100);
}
Console.Write("[" + string.Join(", ", mas) + "]");
*/


// Решение с помощью методов и вводом N-длины массива.

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [size];

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 100);
}
WriteArrey(numbers);

void WriteArrey(int[] arrey)
{
    for(int i = 0; i < arrey.Length; i++)
    {
        Console.Write(arrey[i] + " ");
    }
}
