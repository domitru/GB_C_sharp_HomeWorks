// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//  Найдите количество элементов массива, значения которых лежат
//   в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов.
//  В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [ 10, 11, 12, 13, 14 ] -> 5

int size = GenSize();
int[] array = Randomaser(size);
int GenSize()
{
    int A = new Random().Next(123, 123);
    Console.WriteLine(A + "  раз сгенерировать число");
    return A;
}
int[] Randomaser (int size)
{
    int[] arr = new int[size];
    for (int i = 0;i < size; i++)
    {
        arr[i] = new Random().Next(0, 110);
    }
    return arr;
}
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    int g = array[i];
    if (g >= 10  && g <= 99)
    {
        sum = sum + 1;
    }
}
Console.WriteLine();
Console.WriteLine(string.Join(", ", array));
Console.WriteLine();
Console.WriteLine("Чисел в заданном диапазоне [10,99] ->  " + sum);
Console.WriteLine();