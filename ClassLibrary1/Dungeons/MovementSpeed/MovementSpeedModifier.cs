using System.Collections.Generic;

namespace ToolLibrary.Dungeons.MovementSpeed
{
    internal class MovementSpeed
    {
        public int BaseSpeed { get; }
        public int BonusSpeed {
            get
            {
                var totalBonusSpeed = 0;
                foreach (var moveModifier in ListMoveModifiers)
                    totalBonusSpeed += moveModifier.ReturnMovementModifier();
                return totalBonusSpeed;
            }
        }

        public int AccumulatedMovementSpeed => BaseSpeed + BonusSpeed;

        public List<MovementSpeedModifier> ListMoveModifiers = new List<MovementSpeedModifier>();

        /// <summary>
        /// This method advances all items in the ListMoveModifiers
        /// and only carries the active ones over.
        /// </summary>
        public void NextTurn()
        {
            foreach (var movementSpeedModifier in ListMoveModifiers)
                movementSpeedModifier.NextTurn();

            var tempList = new List<MovementSpeedModifier>();

            for (var i = ListMoveModifiers.Count; i > 0; i++)
                if (ListMoveModifiers[i].Active)
                    tempList.Add(ListMoveModifiers[i]);

            ListMoveModifiers = tempList;
        }

        /// <summary>
        /// Adds a new movement modifier to the list
        /// </summary>
        /// <param name="newMoveModifier">The movement speed modifier to be added to the list</param>
        public void AddMoveModifier (MovementSpeedModifier newMoveModifier)
        {
            ListMoveModifiers.Add(newMoveModifier);
        }

        /// <summary>
        /// This method clears _all_ movement modifiers.
        /// This includes anything from items, spells etc.
        /// </summary>
        public void ResetBonusSpeed()
        {
            ListMoveModifiers.Clear();
        }

        /// <summary>
        /// Constructor for MovementSpeed class
        /// which expect a "baseSpeed" integer
        /// </summary>
        /// <param name="baseSpeed">This should be the race's default speed without modifiers</param>
        public MovementSpeed(int baseSpeed)
        {
            BaseSpeed = baseSpeed;
        }
    }
}
