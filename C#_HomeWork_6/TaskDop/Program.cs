// Дополнительная задача на рекурсию (необязательная)
// Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
// 12345 -> 5

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int c = 1;
int CountNumber(int number)
{
    if (number / 10 == 0) return 1;
    c++;
    CountNumber(number / 10);
    return c;
}
int outMetod = CountNumber(number);
Console.WriteLine("Колличество цифр: ->  " + outMetod);















/*
int c = 1;
int n = 12345;
int f = n / 10 ;
Console.WriteLine(f);
c = c + 1;
Console.WriteLine(c);
Console.WriteLine();
int g = f / 10 ;
Console.WriteLine(g);
c = c + 1;
Console.WriteLine(c);
Console.WriteLine();
int h = g / 10 ;
Console.WriteLine(h);
c = c + 1;
Console.WriteLine(c);
Console.WriteLine();
int j = h / 10 ;
Console.WriteLine(j);
c = c + 1;
Console.WriteLine(c);
Console.WriteLine();
int k = j / 10 ;
Console.WriteLine(k);
c = c + 1;
Console.WriteLine(c);
Console.WriteLine();
*/