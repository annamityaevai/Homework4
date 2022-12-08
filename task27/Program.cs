// Задача 27. Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе.

Console.Write("Insert number: ");
int n = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int n){
    
    int counter = Convert.ToString(n).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = n - n % 10;
      result = result + (n - advance);
      n = n / 10;
    }
   return result;
  }

int sumNumber = SumNumber(n);
Console.WriteLine("Sum of digits: " + sumNumber);