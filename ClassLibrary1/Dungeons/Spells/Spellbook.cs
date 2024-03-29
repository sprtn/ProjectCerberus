﻿using System.Collections.Generic;

namespace Shared.Dungeons.Spells
{
    public class Spellbook
    {
        List<Spell> _mSpellBook;

        public Spellbook()
        {
            _mSpellBook = new List<Spell>
            {
                new Spell(
                    "Fireball",
                    "A bright streak flashes from your pointing finger to a point you choose within range then blossoms with a low roar into an explosion of flame. Each creature in a 20-foot radius sphere centered on that point must make a Dexterity saving throw. A target takes 8d6 fire damage on a failed save, or half as much damage on a successful one. The fire spreads around corners. It ignites flammable objects in the area that aren't being worn or carried.",
                    "Evocation",
                    "Instantaneous",
                    0,
                    "action",
                    1,
                    "ft",
                    150,
                    new List<int>(){
                        3, 4, 5, 6, 7, 8, 9
                    },
                    "At Higher Levels: When you cast this spell using a spell slot of 4th level or higher, the damage increases by 1d6 for each slot level above 3rd.",
                    new Spells.Classes.ClassList(new List<string>()
                    {
                        "Wizard",
                        "Sorcerer"
                    }),
                    new SpellComponents(
                        true,
                        true,
                        true,
                        "A tiny ball of bat guano and sulfur"
                        )
                    )
            };
        }
    }
}
