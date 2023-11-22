string input = "Merhaba Hello Question";

string[] kelimeler = input.Split(" ");

foreach (var kelime in kelimeler)
{
    char a = kelime[0];
    string b = kelime.Substring(1);
    Console.Write($"{b}{a} ");
}
