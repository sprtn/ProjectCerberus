using System.Collections.Generic;
using DungeonsWebApp.Models.SpellModelHelpers.Enums;

namespace DungeonsWebApp.Models.SpellModelHelpers
{
    public class SpellAscension
    {
        public Dictionary<int, bool> LevelsDictionary;
        public string SpellAscensionDescription;
        public List<Helpers.Class> ClassList;

        public SpellAscension (Dictionary<int, bool> levelsDictionary, string spellAscensionDescription, List<Helpers.Class> classList)
        {
            LevelsDictionary = levelsDictionary;
            SpellAscensionDescription = spellAscensionDescription;
            ClassList = classList;
        }
    }
}
