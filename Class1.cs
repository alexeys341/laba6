using System;
using System.Xml.Linq;


namespace lab1_part1
{
    public class Bots
    {
        protected bool want_to_kill;
        protected bool have_weapon;

        public bool need_destroy(bool want_kill, bool weapons)//типо логическое и
        {
            want_to_kill = want_kill;
            have_weapon = weapons;
            if ((want_to_kill == true) && (have_weapon == true))
            {
                Console.WriteLine("Надо уничтожить");
                return true;
            }
            else
            {
                Console.WriteLine("Та забей");
                return false;
            }

        }

        public bool need_destroy()
        {
            if ((want_to_kill == true) && (have_weapon == true))
            {
                Console.WriteLine("Надо уничтожить");
                return true;
            }
            else
            {
                Console.WriteLine("Та забей");
                return false;
            }

        }
        public void copy(Bots origin_bot)//конструктор копирования
        {
            want_to_kill = origin_bot.want_to_kill;
            have_weapon = origin_bot.have_weapon;

        }
    }

    public class Bender : Bots
    {
        private int age;

        public override string ToString()//перегрузка ToString
        {
            return "Bender: хочет уничтожать " + want_to_kill + ", оружие " + have_weapon;
        }

        public string ToString(int ages)
        {
            age = ages;
            if (age > 0)
            {
                return "Bender: хочет уничтожать " + want_to_kill + ", оружие " + have_weapon + ", ты в опасности";
            }
            else
            {
                return "Bender: хочет уничтожать " + want_to_kill + ", оружие " + have_weapon + ", пока что ты живешь ";
            }
        }

        public void when_it_will_be_destroy()//два доп метода
        {
            Console.WriteLine("Он самоуничтожится через " + (10000 - age) + " лет" );
        }

        public void change_age(int year)
        {
            age = year;
            Console.WriteLine("Теперь его возраст: "+ age);
        }
    }

}
