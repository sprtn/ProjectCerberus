using System.Collections.Generic;
using ToolLibrary.Dungeons.Misc;

namespace ToolLibrary.Dungeons.MovementSpeed
{
    internal class MovementSpeed
    {
        public int MBaseSpeed { get; }
        public int MBonusSpeed {
            get
            {
                var returnVal = 0;
                foreach (var m in ListMoveModifiers)
                    returnVal += m.ReturnMovementModifier();
                return returnVal;
            }
        }

        public int MMovementSpeed => MBaseSpeed + MBonusSpeed;

        public List<MovementSpeedModifier> ListMoveModifiers = new List<MovementSpeedModifier>();

        public void AddMoveModifier (MovementSpeedModifier newMoveModifier)
        {
            ListMoveModifiers.Add(newMoveModifier);
        }

        public void ResetBonusSpeed()
        {
            ListMoveModifiers.Clear();
        }

        public MovementSpeed(int baseSpeed)
        {
            MBaseSpeed = baseSpeed;
        }
    }
}
