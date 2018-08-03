using System.Collections.Generic;

namespace ToolLibrary.Dungeons.Abilities
{
    public class Abilities
    {
        // List of abilities and their values.
        public List<Ability> abilityList { get; }

        // Constructor shall fill the ability list.
        public Abilities(Ability strength, Ability dexterity, Ability constitution, Ability intelligence, Ability wisdom, Ability charisma)
        {
            abilityList = new List<Ability>
            {
                strength,
                dexterity,
                constitution,
                intelligence,
                wisdom,
                charisma
            };
        }
    }
}
