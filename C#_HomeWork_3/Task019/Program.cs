/*   Задача 19.
Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да  */

Console.WriteLine("Введите пятизначное число:  ");
string? myArray = Console.ReadLine();
int num = Convert.ToInt32(myArray);
if (num <= 99999)

    if (myArray[0]==myArray[4] && myArray[1]==myArray[3]){
        Console.Write( myArray + " -> " + "yes");}
    else
        {Console.Write( myArray + " -> " + "No");}
else
{Console.Write(" Не пятизначное,ха-ха-ха!");}