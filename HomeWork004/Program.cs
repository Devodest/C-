
/* Задача 25: Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


/* Console.WriteLine("Введите число, которое будем возводить в степени");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа");
int B = int.Parse(Console.ReadLine());
int Z = A;
for (int i = 1; i < B; i++)
{
    Z = Z * A;
}
Console.WriteLine(Z); */


/* Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

/* Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
decimal ostatok = num;
decimal new_ostatok = 0;
decimal result = 0;
while (true)
{
    new_ostatok = Math.Floor(Convert.ToDecimal(ostatok/10));
    result += ostatok % 10;
    if(new_ostatok < 10){
        result += new_ostatok;
        break;
    }
    ostatok = new_ostatok;

}
Console.WriteLine(result); */

Console.WriteLine("Введите число:");
string num = Console.ReadLine();
int result = 0;

for (int i = 0; i < num.Length; i++)
{
    result += int.Parse(num[i].ToString());
}
Console.WriteLine(result);


/* Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */
