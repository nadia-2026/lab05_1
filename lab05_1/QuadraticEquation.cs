using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05_1
{
    internal class QuadraticEquation
    {
        private double a;
        private double b;
        private double c;

        public QuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException("Коэффициент 'a' не может быть равен 0.");
            }
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetDiscriminant()
        {
            return b * b - 4 * a * c;
        }

        public void GetRoots()
        {
            double D = GetDiscriminant();
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"x = {x}");
            }
            else
            {
                Console.WriteLine("Действительных корней нет.");
            }
        }

        public void Print()
        {
            Console.WriteLine($"Уравнение: a = {a}, b = {b}, c = {c}");
            Console.WriteLine($"Дискриминант: {GetDiscriminant()}");
        }
    }
}