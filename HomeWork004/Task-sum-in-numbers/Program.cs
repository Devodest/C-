/* Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int sumChiselInChisle()
{
    Console.WriteLine("Введите число: ");
    int x1 = int.Parse(Console.ReadLine());
    int result = 0;
    int temp = x1;
    for (int i = 0; i < x1; i++)
    {
        result += temp % 10;
        temp = temp / 10;
    }
    Console.WriteLine();
    return result;
}
Console.WriteLine(sumChiselInChisle());