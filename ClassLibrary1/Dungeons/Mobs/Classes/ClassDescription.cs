namespace ToolLibrary.Dungeons.Dice
{
    internal class ClassDescription
    {
        string m_className { get; set; }
        string m_classDescription { get; set; }

        public ClassDescription(string className, string classDescription)
        {
            m_classDescription = classDescription;
            m_className = className;
        }
    }
}