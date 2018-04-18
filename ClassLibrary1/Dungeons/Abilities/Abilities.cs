using System.Collections.Generic;

namespace ToolLibrary.Dungeons.Abilities
{
    public class Abilities
    {
        // List of ability names.
        public List<string> abilityNameList = new List<string>()
        {
            "Strength", "Dexterity", "Constitution",
            "Intelligence", "Wisdom", "Charisma"
        };

        // List of abilities and their values.
        public List<Ability> abilityList { get; }

        // Constructor shall fill the ability list.
        public Abilities(List<int> abilityScoreList)
        {
            // Generate a new ability list
            abilityList = new List<Ability>();

            foreach (string ability in abilityNameList)
            {
                abilityList.Add(new Ability(
                    title: ability,
                    abilityScore: abilityScoreList[abilityNameList.IndexOf(ability)]
                    ));
            }
        }
    }
}
