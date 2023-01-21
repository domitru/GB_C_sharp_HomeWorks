Console.WriteLine("Введите число: ");
string? A = Console.ReadLine();
int n = Convert.ToInt32(A);
int num1= 0;


int count = Convert.ToInt32(A.Length);
int s = 0;
    while(n!=0)
    {
        s = s + n % 10 *-1;
        n = n / 10;
    }
Console.WriteLine(s);   