using System.Net.Mime;
void PrintStringArray(string[] someText)
{
    for (int i = 0; i < someText.Length; i++)
    {
        Console.Write(someText[i] + " ");
    }
    Console.WriteLine();
}

void ReverseStringArray(string[] someText)
{
    string tmp = string.Empty;
    for (int i = 0; i < someText.Length / 2; i++)
    {
        tmp = someText[i];
        someText[i] = someText[someText.Length - i - 1];
        someText[someText.Length - i - 1] = tmp;
    }
}

Console.WriteLine("Vvedite text");
Console.WriteLine();
string someText = Console.ReadLine();
Console.WriteLine();
string[] splitText = someText.Split(" ");


ReverseStringArray(splitText);
Console.WriteLine("Ваш перевёрнутый текст");
Console.WriteLine();
PrintStringArray(splitText);