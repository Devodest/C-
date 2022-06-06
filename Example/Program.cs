// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Напишите программу, которая на вход принимает число и выдаёт его квадрат(число умноженное на само себя)

/* Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()); */

/* Console.WriteLine("Число:" + n);
Console.WriteLine("Квадрат числа :" + n * n); */

/* 1. Напишите программу, которая на вход принимает два
числа и проверяет, является ли первое число квадратом
второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет
3. Напишите программу, которая будет выдавать
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
 */


/* Console.WriteLine("Введите 2 числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if(a * a == b){
    Console.WriteLine("Да, число: " + a + " 1 число является квадратом" + b);
}
else {
    Console.WriteLine("Нет, число: " + a + " 1  число не является квадратом" + b);
} */



 /* int WeekDayNo = int.Parse(Console.ReadLine());

 if (WeekDayNo > 0 && WeekDayNo <= 7 ){
 if (WeekDayNo == 1){
     Console.WriteLine("Monday");
 }
 else if (WeekDayNo == 2){
     Console.WriteLine("Tuesday");
 }
 else if 
     (WeekDayNo == 3){
     Console.WriteLine("Wednesday ");
 }
  else if 
     (WeekDayNo == 4){
     Console.WriteLine("Thursday ");
 }
  else if 
     (WeekDayNo == 5){
     Console.WriteLine("Friday ");
 }
  else if 
     (WeekDayNo == 6){
     Console.WriteLine("Saturday ");
 }
  else if 
     (WeekDayNo == 7){
     Console.WriteLine("Sunday ");
 }
  else{
     Console.WriteLine("Ваше число не правильное");
 }
 } */


 /* 5. Напишите программу, которая на вход принимает
одно число (N), а на выходе показывает все целые
числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"

7. Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2
918 -> 8 */

/* Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int i = n *(-1);

while (i <= n) {
    Console.WriteLine(i);
    i+=1;
} */

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (n > 99 && n < 1000)
{
    Console.WriteLine(n + " mod 10 =" + n % 10);
} 
else {
    Console.WriteLine("Error");
}