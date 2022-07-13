// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string NumberLength = Convert.ToString(number);
if (NumberLength.Length > 2)
{
    Console.WriteLine(NumberLength[2]);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}