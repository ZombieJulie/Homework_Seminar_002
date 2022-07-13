// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int day = int.Parse(Console.ReadLine());
if (day < 6)
{
    Console.WriteLine("Это рабочий день недели.");
}
else if (day > 7)
{
    Console.WriteLine("Нет такого дня недели.");
}
else
{
    Console.WriteLine("Это выходной.");
}
