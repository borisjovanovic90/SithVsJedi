using System.Threading;

namespace SithVsJedi
{
    class Hero
    {
        private const int JEDI_HEALTH_AT_START = 20;
        private const int SITH_HEALTH_AT_START = 20;
        private readonly Side FACTION;

        private bool isAlive;
        private int health;
        private string name;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        private Lightsaber lightsaber;
        private ForceShield forceShield;

        public Hero(string name, Side side)
        {
            this.name = name;
            FACTION = side;
            isAlive = true;

            switch (side)
            {
                case Side.Jedi:
                    lightsaber = new Lightsaber(side);
                    forceShield = new ForceShield(side);
                    health = JEDI_HEALTH_AT_START;
                    break;
                case Side.Sith:
                    lightsaber = new Lightsaber(side);
                    forceShield = new ForceShield(side);
                    health = SITH_HEALTH_AT_START;
                    break;
                default:
                    break;

            }
        }
        public void Attack(Hero oppositeSide)
        {
            int damage = lightsaber.Damage / oppositeSide.forceShield.ForcePoints;
            oppositeSide.health = oppositeSide.health - damage;

            if (oppositeSide.health<=0)
            {
                oppositeSide.isAlive = false;
                Tools.ColourfulConsole($"{oppositeSide.name} is dead.", System.ConsoleColor.Red);
                Tools.ColourfulConsole($"{name} is victorius!.", System.ConsoleColor.Blue);

            }
            else
            {
                System.Console.WriteLine($"{name} attacked {oppositeSide.name}. {damage} damage was inflicted to {oppositeSide.name}. Remaining health of {oppositeSide.name} is {oppositeSide.health}");
            }
            Thread.Sleep(300);
        }


    }
}
