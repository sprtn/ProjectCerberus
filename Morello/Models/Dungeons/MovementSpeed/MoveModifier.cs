namespace Shared.Dungeons.MovementSpeed
{
    public class MovementSpeedModifier
    {
        public readonly int BonusSpeed;
        private int Duration { get; }
        private int TimeSpent { get; set; }
        public bool Active => Duration >= TimeSpent;
        
        public void NextTurn()
        {
            TimeSpent++;
        }

        public int ReturnMovementModifier()
        {
            return BonusSpeed;
        }

        public MovementSpeedModifier(int bonusSpeed, int duration)
        {
            BonusSpeed = bonusSpeed;
            Duration = duration;
        }
    }
}