namespace Shared.Dungeons.Race.RacialTraits
{
    public struct CreatureSize
    {
        public CreatureSize(string m_size) : this()
        {
            this.m_size = m_size;
        }

        string m_size { get; }
    }
}