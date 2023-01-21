// Задача 34: Задайте массив заполненный случайными положительными 
//            трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int size = GenSize();
int[] array = Randomaser(size);
int chet= 0;
int GenSize()
{
    int A = new Random().Next(0, 10);
    Console.WriteLine(A + "  раз сгенерировать 3-х значное число");
    return A;
}
int[] Randomaser (int size)
{
    int[] arr = new int[size];
    for (int i = 0;i < size; i++)
    {
        arr[i] = new Random().Next(100, 999);
    }
    return arr;
}

for (int i = 0; i < array.Length; i++)
{
    int g = array[i] % 2;
        if (g==0)
        {
            chet = chet + 1;
        }
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine("Четных чисел ->  " + chet);