
/*7. Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2
918 -> 8 */

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (n > 99 && n < 1000)
{
    Console.WriteLine(n + " mod 10 =" + n % 10);
} 
else {
    Console.WriteLine("Error");
}