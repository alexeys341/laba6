using System;


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
}
