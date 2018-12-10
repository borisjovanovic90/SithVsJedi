using System;

namespace SithVsJedi
{
    class MainCode
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Hero jedi = new Hero("Luke Skywalker", Side.Jedi);
            Hero sith = new Hero("Darth Vader", Side.Sith);

            while (jedi.IsAlive && sith.IsAlive)
            {
                if (random.Next(0, 10)<5)
                {
                    jedi.Attack(sith);
                }
                else
                {
                    sith.Attack(jedi);
                }
            }
        }
    }
}
