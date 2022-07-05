/* Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


Console.WriteLine("Введите число, которое будем возводить в степени");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа");
int B = int.Parse(Console.ReadLine());
int Z = A;
for (int i = 1; i < B; i++)
{
    Z = Z * A;
}
Console.WriteLine(Z);

