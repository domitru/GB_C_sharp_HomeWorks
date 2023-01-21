// Задача 38: Задайте массив вещественных(тип double) чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int GenSize() 
{
    int A = new Random().Next(1, 15); 
    Console.WriteLine();     
    Console.WriteLine(A + "  раз сгенерировать число");
    Console.WriteLine();
    return A;
}
int size = GenSize();   
double[] Randomaser (int size) 
{
    double[] arr = new double[size];             
    for (int i = 0;i < size; i++)
    {    
        arr[i]= Math.Round((Convert.ToDouble(new Random().Next(-10, 100)) + new Random().NextDouble()),2);   
    }
    return arr;
}
double[]array = Randomaser(size);                                    

double min = array[0];
double max = array[0];
for (int i=0; i < array.Length; i++)
{
    if(min > array[i]) min = array[i];
    else if (max < array[i]) max = array[i];   
}
Console.WriteLine("[ | " + string.Join(" | ", array) + " | ]");
Console.WriteLine();
Console.WriteLine("max = " + max + "    min = " + min + " разница =  " + (max-min));
Console.WriteLine();