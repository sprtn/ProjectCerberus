using System.Collections.Generic;

namespace Shared.Dungeons.Skills
{
    class Skills : List<Skill>
    {
        public Skills()
        {
            // Not sure if this works or if I need to add each and every Skill separately.
            new List<Skill>()
            {
                // Strength Skills
                new Skill("Athletics", false, 0, "Strength"),

                // Dexterity Skills
                new Skill("Acrobatics", false, 0, "Dexterity"),
                new Skill("Sleight of Hand", false, 0, "Dexterity"),
                new Skill("Stealth", false, 0, "Dexterity"),
        
                // Constitution Skills

                // Intelligence Skills
                new Skill("Arcana", false, 0, "Intelligence"),
                new Skill("History", false, 0, "Intelligence"),
                new Skill("Investigation", false, 0, "Intelligence"),
                new Skill("Nature", false, 0, "Intelligence"),
                new Skill("Religion", false, 0, "Intelligence"),

                // Wisdom Skills
                new Skill("Animal Handling", false, 0, "Wisdom"),
                new Skill("Insight", false, 0, "Wisdom"),
                new Skill("Medicine", false, 0, "Wisdom"),
                new Skill("Perception", false, 0, "Wisdom"),
                new Skill("Survival", false, 0, "Wisdom"),

                // Charisma Skills
                new Skill("Deception", false, 0, "Charisma"),
                new Skill("Intimidation", false, 0, "Charisma"),
                new Skill("Performance", false, 0, "Charisma"),
                new Skill("Persuasion", false, 0, "Charisma"),
            };
        }
    }
}
