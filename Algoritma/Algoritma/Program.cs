

Console.Write("Lütfen Bir değer giriniz String,Sayı Şeklinde: ");
string deger = Console.ReadLine();
string[] degerler = deger.Split(",");
int a = Convert.ToInt32(degerler[1]);
string yeni = " ";
foreach (var item in degerler[0])
{
    yeni = degerler[0].Remove(a,1);
}
Console.WriteLine(yeni);