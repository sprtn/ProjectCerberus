using System;
using System.Collections.Generic;
using System.Linq;
using ToolLibrary.Dungeons.Characters.Classes;
using DungeonRace = ToolLibrary.Dungeons.Characters.Race.SizeModifiers.DungeonRace;

namespace ToolLibrary.Dungeons.Mobs.Classes
{
    public partial class DungeonRaces : List<DungeonRace>
    {
        /// <summary>
        /// Simple constructor adding in the different classes.
        /// These values shall be added from the relational 
        /// database once we get there.
        /// </summary>
        public DungeonRaces()
        {
            //foreach (var raceName in Enum.GetNames(typeof(DungeonRace)))
            //    Add(new DungeonRace(raceName, true));
        }

        public List<DungeonRace> GetDungeonRaces() => this;

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
        /// <param name="removeAll">Bool which decides whether to remove all instances found.</param>
        /// <returns>True if a class with the corresponding name was deleted from this list.</returns>
        public void RemoveDungeonClass(string className, bool? removeAll)
        {
            className = className.ToLower();
            if (removeAll == null)
                removeAll = true;

            /* Here we use Linq lookup to access the first DungeonRace
             with the corresponding RaceName variable to the input
             if removeAll is false. Else, we provide the RemoveAll
             function with a working call for any DungeonRace we want
             to remove.
             */

            //if (!Contains(this.FirstOrDefault(x => x.RaceName.ToLower() == className))) return false;
            //{
            //    if ((bool) removeAll)
            //        Remove(this.FirstOrDefault(x => x.RaceName.ToLower() == className && !x.IsOriginalRace));
            //    else
            //        RemoveAll(x => x.RaceName.ToLower() == className && !x.IsOriginalRace);
            //    return true;
            //}
        }
    }
}
