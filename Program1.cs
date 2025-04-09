using System;

namespace lab1_part1
{
    class Program1
    {
        static void Main()
        {
            bool global_flag = true;
            while(global_flag == true)
            {

                bool flag = false;
                while (flag == false)
                {
                    Bots bot1 = new Bots();//тут тестируем класс
                    string weapon;
                    string want;
                    bool weap = false;
                    bool want_to_kill = false;
                    Console.WriteLine("Вводите только 'да' или 'нет' ");
                    Console.WriteLine("У робота есть оружие?");
                    weapon = Console.ReadLine();
                    Console.WriteLine("Хочет ли робот уничтожить людей? ");
                    want = Console.ReadLine();
                    if (weapon == "да")
                    {
                        weap = true;
                        flag = true;
                    }
                    else if (weapon == "нет")
                    {
                        weap = false;
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("Вы неверно ввели наличие оружия, введите заного");
                        flag = false;
                    }

                    if (want == "да")
                    {
                        want_to_kill = true;
                        flag = true;
                    }
                    else if (want == "нет")
                    {
                        want_to_kill = false;
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("Вы неверно ввели наличие желания, введите заного");
                        flag = false;
                    }

                    if (flag == true)
                    {
                        Console.WriteLine("Надо ли уничтожить первого бота?");
                        bot1.need_destroy(weap, want_to_kill);
                    }

                    Bots bot2 = new Bots();
                    bot2.copy(bot1);
                    if (flag == true)
                    {
                        Console.WriteLine("Надо ли уничтожить второго бота?");
                        bot1.need_destroy();
                    }
                }

                Bender bad_bender = new Bender();//тут подкласс
                Console.WriteLine("Появился злой бендер");
                bad_bender.need_destroy(true, true);
                Console.WriteLine("Потому что он всегда злой");
                Console.WriteLine("Укажите его возраст любым целым числом");
                bool flag1 = false;
                int real_age = 42;
                while (flag1 == false)
                {
                    string agge = Console.ReadLine();
                    try
                    {
                        real_age = int.Parse(agge);
                        flag1 = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Вы ввели не число, поэтому его возраст 42: ");

                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("Перегрузим ToString по фану");
                    string str1 = bad_bender.ToString();
                    string str2 = bad_bender.ToString(real_age);
                    Console.WriteLine(str1);
                    Console.WriteLine(str2);

                    //по фану лишние два метода
                    bad_bender.when_it_will_be_destroy();
                    bad_bender.change_age(225);
                    bad_bender.when_it_will_be_destroy();
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
