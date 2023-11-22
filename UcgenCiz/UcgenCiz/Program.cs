Console.Write("Üçgenin uzunluğunu giriniz : ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    for (int j = 1; j <= a - i; j++)
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= 2 * i - 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}