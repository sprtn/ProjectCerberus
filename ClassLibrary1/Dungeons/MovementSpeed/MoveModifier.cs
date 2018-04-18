namespace ToolLibrary.Dungeons.Misc
{
    public class MovementSpeedModifier
    {
        private int m_bonusSpeed;
        private int m_duration { get; }
        private int m_timeSpent { get; set; }

        public bool NextTurn()
        {
            return m_duration > m_timeSpent++;
        }

        public int ReturnMovementModifier()
        {
            return m_bonusSpeed;
        }

        public MovementSpeedModifier(int bonusSpeed, int duration)
        {
            m_bonusSpeed = bonusSpeed;
            m_duration = duration;
        }
    }
}