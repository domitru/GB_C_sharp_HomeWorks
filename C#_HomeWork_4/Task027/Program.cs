// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.
// пример:
//             452 -> 11
//             82 -> 10
//             9012 -> 12


int SummaCifr(int z)
{          
    int s = 0;
    while(z!=0)
    {
        s = s + z % 10;
        z = z / 10;
    }
    return s;
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
//int num = SummaCifr(n);
Console.WriteLine("Сумма чисел равна: {0}",SummaCifr(n));

/*
string strnum = Console.ReadLine();
int sum = 0;

for(int i = 0; i < strnum.Length; i++);
{
    string digit = Convert.ToString(strnum[i]);
    sum += Convert.ToInt32(digit);
}

Console.WriteLine(sum);
*/