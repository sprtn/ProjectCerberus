﻿using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ToolLibrary.Dungeons.Mobs.Classes
{
    public class DungeonRaces : List<DungeonRace>
    {
        /* These should come from a database or even a txt file
         and the values for the different classes should simply be
         fetched, asynchronously, by name. */

        /// <summary>
        /// Simple constructor adding in the different classes.
        /// 
        /// These values shall be added from the relational 
        /// database once we get there.
        /// </summary>
        public DungeonRaces()
        {
            AddOriginalRace("Human");
            AddOriginalRace("Half-Orc");
            AddOriginalRace("Orc");
            AddOriginalRace("Half-Elf");
            AddOriginalRace("Elf");
            AddOriginalRace("Goblin");
        }

        public List<DungeonRace> GetDungeonRaces() => this;

        /// <summary>
        /// This class adds original DungeonRaces to the list.
        /// </summary>
        /// <param name="className">Race name is used for lookup purposes.</param>
        private void AddOriginalRace(string className)
        {
            Add(new DungeonRace(className, true));
        }

        /// <summary>
        /// This method adds a new dungeon class to to the list
        /// </summary>
        /// <param name="dungeonRace">The DungeonRace which is to be added</param>
        public void AddDungeonClass(DungeonRace dungeonRace)
        {
            Add(dungeonRace);
        }

        /// <summary>
        /// This method removes the first instance of a class with
        /// the corresponding input classname that is not a part of the
        /// original classes of the application. Ie. any homebrew class
        /// with a corresponding name will be removed. Built-in classes will not.
        /// 
        /// This can be useful for removing classes mislabeled with
        /// the same names as existing classes. This does not
        /// delete any such class from the database.
        /// </summary>
        /// <param name="className">String of a class name</param>
        /// <param name="multiplicity">Bool which decides whether all instances of</param>
        /// <returns>True if a class with the corresponding name was deleted from this list.</returns>
        public bool RemoveDungeonClass(string className, bool? multiplicity)
        {
            className = className.ToLower();
            if (multiplicity == null)
                multiplicity = true;

            /* Here we use Linq lookup to access the first DungeonRace
             with the corresponding ClassName variable to the input
             if multiplicity is false. Else, we provide the RemoveAll
             function with a working call for any DungeonRace we want
             to remove.
             */

            if (!Contains(this.FirstOrDefault(x => x.ClassName.ToLower() == className))) return false;
            {
                if ((bool) multiplicity)
                    Remove(this.FirstOrDefault(x => x.ClassName.ToLower() == className && !x.IsOriginalClass));
                else
                    RemoveAll(x => x.ClassName.ToLower() == className && !x.IsOriginalClass);
                return true;
            }
        }
    }
}