using System;
using System.Security.Cryptography;

namespace lab1_part2
{
    class Triangles
    {
        private float a = 0;
        private float b = 0;
        private float c = 0;

        public bool check(float _a, float _b, float _c)
        {
            a = _a;
            b = _b;
            c = _c;

            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                Console.WriteLine("Такой треугольник существует");
                return true;
            }
            else if ((a + b == c) || (b + c == a) || (a + c == b))
            {
                Console.WriteLine("Это не треугольник, а прямая линия");
                return false;
            }
            else
            {
                Console.WriteLine("Это не треугольник, а какие-то три отрезка");
                return false;
            }
        }

        public double square()
        {
            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                double p = (a + b + c) / 2;
                double Square = p * (p - a) * (p - b) * (p - c);
                Square = Math.Sqrt(Square);
                return Square;
            }
            else
            {
                return 0;
            }
        }

        public double square(float _a, float _b, float _c)
        {
            a = _a;
            b = _b;
            c = _c;

            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                double p = (a + b + c) / 2;
                double Square = p * (p - a) * (p - b) * (p - c);
                Square = Math.Sqrt(Square);
                return Square;
            }
            else
            {
                return 0;
            }
        }

        public double perimetr(double _a, double _b, double _c)
        {
            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                double Perim = _a + _b + _c;
                return Perim;
            }
            else
            {
                return 0;
            }
        }

        public static bool operator>(Triangles one, Triangles two)
        {
            double Square1;
            double Square2;

            if ((one.a + one.b > one.c) && (one.b + one.c > one.a) && (one.a + one.c > one.b))
            {
                double p = (one.a + one.b +  one.c) / 2;
                Square1 = p * (p - one.a) * (p - one.b) * (p - one.c);
                Square1 = Math.Sqrt(Square1);
            }
            else
            {
                Square1 = 0;
            }

            if ((two.a + two.b > two.c) && (two.b + two.c > two.a) && (two.a + two.c > two.b))
            {
                double p = (two.a + two.b + two.c) / 2;
                Square2 = p * (p - two.a) * (p - two.b) * (p - two.c);
                Square2 = Math.Sqrt(Square2);
            }
            else
            {
                Square2 = 0;
            }

            if (Square1 > Square2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator<(Triangles one, Triangles two)
        {
            double Square1;
            double Square2;

            if ((one.a + one.b > one.c) && (one.b + one.c > one.a) && (one.a + one.c > one.b))
            {
                double p = (one.a + one.b + one.c) / 2;
                Square1 = p * (p - one.a) * (p - one.b) * (p - one.c);
                Square1 = Math.Sqrt(Square1);
            }
            else
            {
                Square1 = 0;
            }

            if ((two.a + two.b > two.c) && (two.b + two.c > two.a) && (two.a + two.c > two.b))
            {
                double p = (two.a + two.b + two.c) / 2;
                Square2 = p * (p - two.a) * (p - two.b) * (p - two.c);
                Square2 = Math.Sqrt(Square2);
            }
            else
            {
                Square2 = 0;
            }

            if (Square1 < Square2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*public void check(Triangles class_name)
        {
            a = class_name.a;
            b = class_name.b;
            c = class_name.c;

            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                Console.WriteLine("Такой треугольник существует");
            }
            else if ((a + b == c) || (b + c == a) || (a + c == b))
            {
                Console.WriteLine("Это не треугольник, а прямая линия");
            }
            else
            {
                Console.WriteLine("Это не треугольник, а какие-то три отрезка");
            }
        }*/
    }
}

