using System;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy e1 = new Enemy(88);
            Enemy e2 = new Enemy();
            

            int dmg = e1.Attack();

            e1.Hurt();

            e1.Draw();

            Console.ReadLine();
        }
    }
}
