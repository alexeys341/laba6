using System;

namespace lab1_part1
{
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
            Console.WriteLine("Он самоуничтожится через " + (10000 - age) + " лет");
        }

        public void change_age(int year)
        {
            age = year;
            Console.WriteLine("Теперь его возраст: " + age);
        }
    }
}
