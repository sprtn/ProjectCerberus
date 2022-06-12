namespace Shared.Dungeons.Spells.Classes
{
    public class ClassListClass
    {
        public string m_name = "";
        public bool m_accepted = false;

        public ClassListClass(bool accepted, string name)
        {
            m_name = name;
            m_accepted = accepted;
        }
    }
}