// // Напишите программу, которая принимает на 
// // координаты двух точек и находит расстояние между ними в 2D пространстве.

// // A (3,6); B (2,1) -> 5,09
// // A (7,-5); B (1,-1) -> 7,21

// /*Console.WriteLine("Введите координату X точки А: ");
// int Ax = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y точки А: ");
// int Ay = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату X точки B: ");
// int Bx = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y точки B: ");
// int By = Convert.ToInt32(Console.ReadLine());

// double distance = Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay,2)), 2);
// Console.WriteLine(distance);*/
// //Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay,2))

// /*Console.WriteLine("Введите координаты точки А (x,y,z):");
// String pointA = Console.ReadLine();
// string[] arrA = pointA.Split(",");
// int numA = (Convert.ToInt32(arrA));

// Console.WriteLine("Введите координаты точки В (x,y,z):");
// String pointB = Console.ReadLine();
// string[] arrB = pointB.Split(",");
// int numB = (Convert.ToInt32(arrB));   */


// //Console.WriteLine(Math.Sqrt(Math.Pow(arrB[0]-arrA[0],2) + Math.Pow(arrB[1]-arrA[1],2) + Math.Pow(arrB[2]-arrA[2],2)));
// //int numA = Math.Abs(Convert.ToInt32(myArray));

// Console.WriteLine("Введите координаты точки А (x,y,z):");
// string? strA = Console.ReadLine();
// string[] arrA= strA.Split(",");
// int[] strA1 = Array.ConvertAll(arrA, int.Parse);

// Console.WriteLine("Введите координаты точки B (x,y,z):");
// string? strB = Console.ReadLine();
// string[] arrB= strB.Split(",");
// int[] strB1 = Array.ConvertAll(arrB, int.Parse);

// double s = Math.Sqrt(Math.Pow(strB1[0]-strA1[0],2) + Math.Pow(strB1[1]-strA1[1],2) + Math.Pow(strB1[2]-strA1[2],2));

// Console.Write(s); 




        //string str;
        //Console.WriteLine("Введите числа через пробелы");
        //str = Console.ReadLine();
        //string[] str1 = str.Split(' ');
 
       //Преобразование Массива типа String[] в тип Int[] -C#
        //int[] str2 = Array.ConvertAll(str1, int.Parse)
   //int z= arrA[0]+arrA[2];
//Console.Write (z);

//int a[]={pointA.Split(,)};


// Задача 26: Напишите программу,
//  которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// Console.WriteLine("Введите число");
// string A = Convert.ToString(Console.ReadLine());
// int B = Convert.ToInt32(Console.ReadLine());
// if (Видимо )

// int i = A.Length;
// Console.WriteLine(i);



// 26 задача
// Console.WriteLine("Введите число");
// string? A = Convert.ToString(Console.ReadLine());
// if (int.TryParse(A, out int num))
//     Console.Write("Количество цифр в числе: " + A.Length);
// else
//     Console.Write("В строке не только цифры, напишите число");
// символов

// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9,10);
    }
    return arr;
}
Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
int sumPositive = 0;
int sumNegative = 0;
Console.WriteLine(string.Join(", ", array));
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        sumPositive+=array[i];
    }
    else
    {
        sumNegative+=array[i];
    }
}
Console.WriteLine($"Сумма положительных чисел = {sumPositive}, сумма отрицательных чисел = {sumNegative}");
