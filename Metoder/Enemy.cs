using System;

namespace Metoder
{
    public class Enemy
    {
        static Random generator = new Random();

        public int hp = generator.Next(3,50);

        public Enemy (int number)
        {
            
        }

        public Enemy()
        {
          int choice = generator.Next(2);

          if (choice == 0)
          {
              hp = 50;
          }

          else
          {
              hp = 100;
          }
        }



        public int Attack()
        {
            return 2;
        }

        public void Draw()
        {
          Console.WriteLine("@ Picture");
        }

        public void Hurt()
        {
          hp--;

          if (hp < 0)
          {
            hp = 0;
          }

          System.Console.WriteLine("OH NYOOOO!" + hp + " left");
        }
    }
}
