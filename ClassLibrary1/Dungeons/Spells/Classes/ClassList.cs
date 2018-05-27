using System.Collections.Generic;

namespace ToolLibrary.Dungeons.Spells.Classes
{
    public class ClassList : List<ClassListClass>
    {
        // List all viable classes
        List<string> classNameList = new List<string>
        {
            "Barbarian", "Bard", "Druid", "Monk",
            "Paladin", "Ranger", "Sorcerer", "Warlock"
        };

        // Constructor
        public ClassList(List<string> list)
        {
            // New list of classes for the class-list
            new List<ClassListClass>();

            // Create all viable classes
            foreach (string name in classNameList)
                Add(new ClassListClass(false, name));

            // Remove the "false" in the previous foreach to accomodate
            // for a search function through the incoming List<string>
            // to look for a match if RaceName fits with any name provided.
            // Need to rewrite the search function. It is not important for now.
            foreach (string classListClass in list)
            {
                if (Exists(x => x.m_name == classListClass))
                    Find(x => x.m_name == classListClass).m_accepted = true;
            }
        }
    }
}