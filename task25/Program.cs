// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = a;
for(int i=1; i < b; i++)
{
    result = result * a;
  }
Console.WriteLine("A в степени B равно: " + result);