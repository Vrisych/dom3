// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначое число и я покажу второе число");
string num = Console.ReadLine();
if (num.Length == 3) Console.WriteLine($"{num[1]}");
else Console.WriteLine("Число не трехзначное");