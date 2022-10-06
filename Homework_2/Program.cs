/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным. */

int rand;

rand = new Random().Next(1, 8);

Console.WriteLine(rand);

if (rand == 6 || rand == 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}



