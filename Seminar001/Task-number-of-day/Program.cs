/*3. Напишите программу, которая будет выдавать
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
 */


 int WeekDayNo = int.Parse(Console.ReadLine());

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
 }