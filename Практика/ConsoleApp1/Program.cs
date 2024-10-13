using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //17. Меняет знак у переменной х на противоположный и выполняет умножение на вещественное число y:
            /*
            Console.Write("x= ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y= ");
            double y = double.Parse(Console.ReadLine());
            double opposite = x * (-1);
            double result = opposite * y;
            if (x>=0)
            {
               
                Console.WriteLine($"-x={opposite}\t-x*y={opposite}*{y}={result}");                
            }
            else
            {
                Console.WriteLine($"x={opposite}\tx*y={opposite}*{y}={result}");
            }
            */






            //17.Дано четырехзначное число. Найти число, полученное при прочтении его цифр справа налево.
            /*
            Console.Write("Введите 4-значное число: ");
            int number = int.Parse(Console.ReadLine());
            int opposite = 0;

            if(number<1000 || number > 9999)
            {
                Console.Write("Введите пожалуйста 4-значное число!");
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    int last = number % 10;
                    opposite = opposite * 10 + last;
                    number /= 10;
                }
                Console.Write(opposite);
            }
            */








            //  17.радиус окружности, вписанной в равносторонний треугольник со стороной а;
            /*
            Console.Write("Введите длину стороны a: ");
            double a = double.Parse(Console.ReadLine());
            double R;

            R = a / (2 * Math.Sqrt(3));
            Console.Write($"{R:f2}");
            */





            Console.ReadKey();
        }
    }
}
