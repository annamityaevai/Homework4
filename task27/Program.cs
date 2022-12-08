// Задача 27. Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе.

Console.Write("Insert number: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (n > 0)
{
int i = n % 10;
n = n / 10;
sum = sum + i;
}
Console.WriteLine("Sum of digits: " + sum);