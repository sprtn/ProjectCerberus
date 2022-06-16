using System.Collections.Generic;
using Shared.Dungeons.SavingThrows;

namespace Shared.Dungeons.Proficiencies.SavingThrows
{
    public class SavingThrows : List<SavingThrow>
    {
        public SavingThrows()
        {
            new List<SavingThrow>()
            {
                new SavingThrow("Strength", false, 0, ""),
                new SavingThrow("Dexterity", false, 0, ""),
                new SavingThrow("Constitution", false, 0, ""),
                new SavingThrow("Intelligence", false, 0, ""),
                new SavingThrow("Wisdom", false, 0, ""),
                new SavingThrow("Charisma", false, 0, "")
            };
        }

        //public void ChangeAbityModifier(string , int abilityModifier)
        //{

        //}
    }
}