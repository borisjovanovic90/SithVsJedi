namespace SithVsJedi
{
     class ForceShield
    {
        private const int JEDI_SHIELD = 5;
        private const int SITH_SHIELD = 5;
        private int forcePoints;

        public int ForcePoints
        {
            get
            {
                return forcePoints;
            }
        }

        public ForceShield(Side side)
        {
            switch (side)
            {
                case Side.Jedi:
                    forcePoints = JEDI_SHIELD;
                    break;
                case Side.Sith:
                    forcePoints = SITH_SHIELD;
                    break;
                default:
                    break;
            }

        }
    }
}