Console.WriteLine("Введите число: ");

string? z = Console.ReadLine();

int a = Convert.ToInt32(z);

Console.Write(a + " -> ");



for (int i = 2; i < a - 1; i = i + 2)
{
    Console.Write(i + ", ");
}
if (0 == a % 2)
{
    Console.Write(a);
}
else
{
    Console.Write(a - 1);


    int a = 1234;
    string str = a.ToString();
    int[] b = new int[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        b[i] = int.Parse(str[i]);  // или так  b[i] = int.Parse(str[i].ToString());
    }
