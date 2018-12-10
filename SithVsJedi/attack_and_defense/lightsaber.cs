namespace SithVsJedi
{
    class Lightsaber
    {
        private const int JEDI_DAMAGE = 5;
        private const int SITH_DAMAGE = 5;
        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
                
        }

        public Lightsaber (Side side)
        {
            switch (side)
            {
                case Side.Jedi:
                    damage = JEDI_DAMAGE;
                    break;
                case Side.Sith:
                    damage = SITH_DAMAGE;
                    break;
                default:
                    break;
            }
        }



    }
}