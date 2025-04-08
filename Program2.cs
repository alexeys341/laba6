using System;

namespace lab1_part2
{
    class Program2
    {
        static void Main()
        {
            bool global_flag = true;
            while(global_flag == true)
            {
                bool all_good = false;
                bool all_good1 = false;
                Triangles first = new Triangles();
                while (all_good == false)
                {
                    Triangles first1 = new Triangles();//тут делается создание элемента
                    string a1;
                    string b1;
                    string c1;
                    float a;
                    float b;
                    float c;
                    bool result;
                    Console.WriteLine("Введите a: ");
                    a1 = Console.ReadLine();
                    Console.WriteLine("Введите b: ");
                    b1 = Console.ReadLine();
                    Console.WriteLine("Введите c: ");
                    c1 = Console.ReadLine();
                    try
                    {
                        a = float.Parse(a1);
                        try
                        {
                            b = float.Parse(b1);
                            try
                            {
                                c = float.Parse(c1);
                                if ((a >= 0) && (b >= 0) && (c >= 0))
                                {
                                    result = first1.check(a, b, c);
                                    Console.WriteLine(result);
                                    first = first1;
                                    all_good = true;
                                }
                                else
                                {
                                    Console.WriteLine("Какое-то из чисел отрицательное");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("c не число: ");
                            }

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("b не число: ");
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("a не число: ");
                    }
                }

                while (all_good1 == false)
                {
                    Triangles second = new Triangles();//тут делается создание элемента
                    string a2;
                    string b2;
                    string c2;
                    float a;
                    float b;
                    float c;
                    bool result;
                    Console.WriteLine("Введите a для второго треугольника: ");
                    a2 = Console.ReadLine();
                    Console.WriteLine("Введите b для второго треугольника: ");
                    b2 = Console.ReadLine();
                    Console.WriteLine("Введите c для второго треугольника: ");
                    c2 = Console.ReadLine();
                    try
                    {
                        a = float.Parse(a2);
                        try
                        {
                            b = float.Parse(b2);
                            try
                            {
                                c = float.Parse(c2);
                                if ((a >= 0) && (b >= 0) && (c >= 0))
                                {
                                    result = second.check(a, b, c);
                                    Console.WriteLine(result);
                                    all_good1 = true;
                                }
                                else
                                {
                                    Console.WriteLine("Какое-то из чисел отрицательное");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("c не число: ");
                            }

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("b не число: ");
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("a не число: ");
                    }

                    if (all_good1 == true)
                    {
                        double Sq2 = -second;
                        Console.WriteLine("Вот площадь второго треугольника");
                        Console.WriteLine(Sq2);
                        double Sq1 = -first;
                        Console.WriteLine("А вот площадь первого треугольника");
                        Console.WriteLine(Sq1);

                        //тут рандомный треугольник для явной и не явной
                        Triangles third = new Triangles();
                        int x = 5;
                        int y = 6;
                        int z = 7;

                        
                        third.give(x, y, z);

                        Console.WriteLine("Существование рандомного треугольника(со сторонами 5,6,7), но уже через перегрузку");
                        result = (bool)third;
                        Console.WriteLine(result);

                        Console.WriteLine("Периметр рандомного треугольника");
                        double P = (double)third;
                        Console.WriteLine(P);

                        Console.WriteLine("Площадь рандомного треугольника");
                        double Sq3 = -third;
                        Console.WriteLine(Sq3);

                        Console.WriteLine("Сравним площади рандомного треугольника и второго");
                        bool which_more1 = third > second;
                        bool which_more2 = third < second;
                        if (which_more1 == true)
                        {
                            Console.WriteLine("Площадь рандомного треугольника больше");
                        }
                        else if (which_more2 == true)
                        {
                            Console.WriteLine("Площадь рандомного треугольника меньше");
                        }
                        else
                        {
                            Console.WriteLine("Площади равны");
                        }

                    }
                }
                Console.WriteLine("На q выход, иначе продожить");
                string q = Console.ReadLine();
                if (q == "q")
                {
                    global_flag = false;
                }
            }
        }
    }
}