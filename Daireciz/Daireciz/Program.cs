Console.WriteLine("Lütfen bir Daire Çapı giriniz: ");
int yaricap = int.Parse(Console.ReadLine());

for (int i = 1; i < yaricap; i++)
{
    for (global::System.Int32 j = 0; j <= yaricap; j++)
    {
        Console.Write(" ");
    }
    for (global::System.Int32 j = 0; j < i ; j++)
    {
        Console.WriteLine("*");
    }
    Console.WriteLine();
}