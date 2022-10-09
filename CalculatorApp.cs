using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp1
{
    public class CalculatorApp
    {
        public static double Adding(int num)
        {
            double sum = 0;
            Console.WriteLine("Enter " + num + " digits to add: ");
            for (int i = 0; i < num; i++)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                sum += x;
            }
            return sum;
        }

        public static double Subtracting(double x, double y)
        {
            if (x > y)
            {
                return x - y;
            }
            return y - x;
        }

        public static double Dividing(double num, double denom)
        {
            return num / denom;
        }

        public static double Multiply(int num)
        {
            double product = 1;
            Console.WriteLine("Enter "+num+ " digits to multiply: ");
            for (int i = 0; i < num; i++)
            {
                double x = Convert.ToDouble(Console.ReadLine());
                product *= x;
            }
            return product;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Addition");
            double a = Adding(3);
            Console.WriteLine("Sum is: " + a + "\n");

            Console.WriteLine("Subtraction");
            double b = Subtracting(5, 8);
            Console.WriteLine("Difference is: " + b + "\n");

            Console.WriteLine("Division");
            double c = Dividing(5, 2);
            Console.WriteLine("Quotient is " + c + "\n");

            Console.WriteLine("Multiplication");
            double d = Multiply(3);
            Console.WriteLine("Product is: " + d + "\n");
        }
    }
}