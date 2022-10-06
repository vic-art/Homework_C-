/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным. */

int N;

Console.WriteLine("Введите число: (1 - понедельник, 2 - вторник, ..., 7 - воскресенье)");
int.TryParse(Console.ReadLine()!, out N);


if (N == 6 || N == 7)
{
    Console.WriteLine("да");
}
else if (N >= 1 && N < 6) 
{
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine("Некорректный ввод");
}



