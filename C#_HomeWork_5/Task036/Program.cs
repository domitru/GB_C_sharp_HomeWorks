// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях(индексах).

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int size = GenSize();
int[] array = Randomaser(size);
int GenSize()
{
    int A = new Random().Next(0, 16);       //Сменяемый диапазон,в зависимости от нужд задач.
    Console.WriteLine(A + "  раз сгенерировать число");
    return A;
}
int[] Randomaser (int size)
{
    int[] arr = new int[size];               // size -  сгенерированный параметр из GenSize.
    for (int i = 0;i < size; i++)
    {
        arr[i] = new Random().Next(0, 99);   // Сменяемый диапазон,в зависимости от нужд задач.
    }
    return arr;
}
int sum = 0;
for (int i = 1; i < array.Length; i=i+2)
{
    int g = array[i];
        sum = sum + g;
}
Console.WriteLine();
Console.WriteLine(string.Join(", ", array));
Console.WriteLine();
Console.WriteLine("Сумма  элементов,стоящих на нечётных позициях(индексах).->  " + sum);
Console.WriteLine();