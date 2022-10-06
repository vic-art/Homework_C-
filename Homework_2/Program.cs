/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int rand;
rand = new Random().Next();
int temp = rand;
int numDigits = 0;
int thirdDigit;

Console.WriteLine($"Число: {rand}");

while (temp > 0)
{
    temp = temp / 10;
    numDigits++;
    if (temp == 0) 
        break;
}
Console.WriteLine($"Кол-во цифр в числе: {numDigits}");

if (numDigits < 3)
{
    Console.WriteLine("Третьей цифры нет");
}

else if (numDigits == 3)
{
    thirdDigit = rand % 10;
    Console.WriteLine($"Третья цифра: {thirdDigit}");
}

else 
{
   thirdDigit = rand / (int)Math.Pow(10, numDigits-3) % 10;
   Console.WriteLine($"Третья цифра: {thirdDigit}");
}

