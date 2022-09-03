using System;
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
namespace Semin2DZ2
{
    class Program
    {
        static void Main(string[] args) {
        Console.WriteLine("Введите число:");
        int chislo = int.Parse(Console.ReadLine());
        string NewChislo = Convert.ToString(chislo);
        if (chislo > 99)
          {
             Console.WriteLine($"Третья цифра числа {chislo} это: {NewChislo[2]}");
          }
        else
          {
             Console.WriteLine($"Третьей цифры нет"); 
          }
        }
    }
}
