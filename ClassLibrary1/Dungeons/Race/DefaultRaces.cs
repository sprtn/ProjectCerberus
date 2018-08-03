using System.Collections.Generic;
using ToolLibrary.Dungeons.Abilities;
using ToolLibrary.Dungeons.Characters.Race;
using ToolLibrary.Dungeons.Spells;

namespace ToolLibrary.Dungeons.Race
{
    public class DefaultRaces
    {
        public List<DefaultRace> ListofDefaultRaces;

        public DefaultRaces()
        {
            ListofDefaultRaces = PopulateDefaults(new List<DefaultRace>());
        }

        private static List<DefaultRace> PopulateDefaults(List<DefaultRace> defaultRaces)
        {
            defaultRaces.Add(new DefaultRace(
                name: "Dragonborn",
                description: "",
                abilities: new Abilities.Abilities(
                    strength: new Ability("Strength", 2),
                    dexterity: new Ability("Dexterity", 0),
                    constitution: new Ability("Constitution", 0),
                    intelligence: new Ability("Intelligence", 0),
                    wisdom: new Ability("Wisdom", 0),
                    charisma: new Ability("Charisma", 1)
                ),
                ageDescription:
                "Young dragonborn grow quickly. They walk hours after hatching, attain the size and development of a 10-year-old human child by the age of 3, and reach Adulthood by 15. They live to be around 80.",
                alignmentDescription:
                "Dragonborn tend to extremes, making a conscious choice for one side or the other in the cosmic war between good and evil. Most dragonborn are good, but those who side with evil can be terrible villains.",
                sizeDescription:
                "Dragonborn are taller and heavier than humans, standing well over 6 feet tall and averaging almost 250 pounds. Your size is Medium.",
                sizeCategory: DungeonRace.SizeCategory.Medium,
                speed: 30,
                raceSpecificSpells: new List<Spell>(),
                languages: new List<string>
                {
                    "Common",
                    "Draconic"
                }
            ));

            defaultRaces.Add(new DefaultRace(
                name: "Dwarf",
                description: "",
                abilities: new Abilities.Abilities(
                    strength: new Ability("Strength", 0),
                    dexterity: new Ability("Dexterity", 0),
                    constitution: new Ability("Constitution", 2),
                    intelligence: new Ability("Intelligence", 0),
                    wisdom: new Ability("Wisdom", 0),
                    charisma: new Ability("Charisma", 0)
                ),
                ageDescription:
                "Dwarves mature at the same rate as humans, but they’re considered young until they reach the age of 50. On average, they live about 350 years.",
                alignmentDescription:
                "Most Dwarves are lawful, believing firmly in the benefits of a well-ordered society. They tend toward good as well, with a strong sense of Fair Play and a belief that everyone deserves to share in the benefits of a just order.",
                sizeDescription:
                "Dwarves stand between 4 and 5 feet tall and average about 150 pounds. Your size is Medium.",
                sizeCategory: DungeonRace.SizeCategory.Medium,
                speed: 25,
                raceSpecificSpells: new List<Spell>(),
                languages: new List<string>
                {
                    "Common",
                    "Dwarvish"
                },
                darkvisionDescription:
                " Accustomed to life underground, you have superior vision in dark and dim Conditions. You can see in dim light within 60 feet of you as if it were bright light, and in Darkness as if it were dim light. You can’t discern color in Darkness, only shades of gray."
            ));

            defaultRaces.Add(new DefaultRace(
                name: "Elf",
                description: "",
                abilities: new Abilities.Abilities(
                    strength: new Ability("Strength", 0),
                    dexterity: new Ability("Dexterity", 2),
                    constitution: new Ability("Constitution", 0),
                    intelligence: new Ability("Intelligence", 0),
                    wisdom: new Ability("Wisdom", 0),
                    charisma: new Ability("Charisma", 0)
                ),
                ageDescription:
                "Although elves reach physical maturity at about the same age as humans, the elven understanding of Adulthood goes beyond physical growth to encompass worldly experience. An elf typically claims Adulthood and an adult name around the age of 100 and can live to be 750 years old.",
                alignmentDescription:
                "Elves love freedom, variety, and self- expression, so they lean strongly toward the gentler aspects of chaos. They value and protect others’ freedom as well as their own, and they are more often good than not.",
                sizeDescription:
                "Elves range from under 5 to over 6 feet tall and have slender builds. Your size is Medium.",
                sizeCategory: DungeonRace.SizeCategory.Medium,
                speed: 30,
                raceSpecificSpells: new List<Spell>(),
                languages: new List<string>
                {
                    "Common",
                    "Elvish"
                },
                darkvisionDescription:
                "Accustomed to twilit forests and the night sky, you have superior vision in dark and dim Conditions. You can see in dim light within 60 feet of you as if it were bright light, and in Darkness as if it were dim light. You can’t discern color in Darkness, only shades of gray."
            ));

            defaultRaces.Add(new DefaultRace(
                name: "Gnome",
                description: "",
                abilities: new Abilities.Abilities(
                    strength: new Ability("Strength", 0),
                    dexterity: new Ability("Dexterity", 0),
                    constitution: new Ability("Constitution", 0),
                    intelligence: new Ability("Intelligence", 2),
                    wisdom: new Ability("Wisdom", 0),
                    charisma: new Ability("Charisma", 0)
                ),
                ageDescription:
                "Gnomes mature at the same rate humans do, and most are expected to settle down into an adult life by around age 40. They can live 350 to almost 500 years.",
                alignmentDescription:
                "Gnomes are most often good. Those who tend toward law are sages, engineers, researchers, scholars, investigators, or inventors. Those who tend toward chaos are minstrels, tricksters, wanderers, or fanciful jewelers. Gnomes are good-hearted, and even the tricksters among them are more playful than vicious.",
                sizeDescription:
                "Gnomes are between 3 and 4 feet tall and average about 40 pounds. Your size is Small.",
                sizeCategory: DungeonRace.SizeCategory.Small,
                speed: 25,
                raceSpecificSpells: new List<Spell>(),
                languages: new List<string>
                {
                    "Common",
                    "Gnomish"
                },
                darkvisionDescription:
                "Accustomed to life underground, you have superior vision in dark and dim Conditions. You can see in dim light within 60 feet of you as if it were bright light, and in Darkness as if it were dim light. You can’t discern color in Darkness, only shades of gray."
            ));

            defaultRaces.Add(new DefaultRace(
                name: "Half-Elf",
                description: "",
                abilities: new Abilities.Abilities(
                    strength: new Ability("Strength", 0),
                    dexterity: new Ability("Dexterity", 0),
                    constitution: new Ability("Constitution", 0),
                    intelligence: new Ability("Intelligence", 0),
                    wisdom: new Ability("Wisdom", 0),
                    charisma: new Ability("Charisma", 2)
                ),
                ageDescription:
                "Half-elves mature at the same rate humans do and reach Adulthood around the age of 20. They live much longer than humans, however, often exceeding 180 years.",
                alignmentDescription:
                "Half-elves share the chaotic bent of their elven heritage. They value both personal freedom and creative expression, demonstrating neither love of leaders nor desire for followers. They chafe at rules, resent others’ demands, and sometimes prove unreliable, or at least unpredictable.",
                sizeDescription:
                "Half-elves are about the same size as humans, ranging from 5 to 6 feet tall. Your size is Medium.",
                sizeCategory: DungeonRace.SizeCategory.Medium,
                speed: 30,
                raceSpecificSpells: new List<Spell>(),
                languages: new List<string>
                {
                    "Common",
                    "Gnomish"
                },
                darkvisionDescription:
                "Thanks to your orc blood, you have superior vision in dark and dim Conditions. You can see in dim light within 60 feet of you as if it were bright light, and in Darkness as if it were dim light. You can’t discern color in Darkness, only shades of gray."
            ));

            defaultRaces.Add(new DefaultRace(
                name: "Half-Orc",
                description: "Your half-orc character has certain traits deriving from your orc ancestry.",
                abilities: new Abilities.Abilities(
                    strength: new Ability("Strength", 2),
                    dexterity: new Ability("Dexterity", 0),
                    constitution: new Ability("Constitution", 1),
                    intelligence: new Ability("Intelligence", 0),
                    wisdom: new Ability("Wisdom", 0),
                    charisma: new Ability("Charisma", 0)
                ),
                ageDescription:
                "Half-Orcs mature a little faster than humans, reaching Adulthood around age 14. They age noticeably faster and rarely live longer than 75 years.",
                alignmentDescription:
                "Half-Orcs inherit a tendency toward chaos from their orc parents and are not strongly inclined toward good. Half-Orcs raised among orcs and willing to live out their lives among them are usually evil.",
                sizeDescription:
                "Half-Orcs are somewhat larger and bulkier than humans, and they range from 5 to well over 6 feet tall. Your size is Medium.",
                sizeCategory: DungeonRace.SizeCategory.Medium,
                speed: 30,
                raceSpecificSpells: new List<Spell>(),
                languages: new List<string>
                {
                    "Common",
                    "Orc"
                }
            ));

            defaultRaces.Add(new DefaultRace(
                name: "Halfling",
                description: "Your halfling character has a number of traits in Common with all other Halflings.",
                abilities: new Abilities.Abilities(
                    strength: new Ability("Strength", 0),
                    dexterity: new Ability("Dexterity", 2),
                    constitution: new Ability("Constitution", 0),
                    intelligence: new Ability("Intelligence", 0),
                    wisdom: new Ability("Wisdom", 0),
                    charisma: new Ability("Charisma", 0)
                ),
                ageDescription:
                "A halfling reaches Adulthood at the age of 20 and generally lives into the middle of his or her second century.",
                alignmentDescription:
                "Most Halflings are lawful good. As a rule, they are good-hearted and kind, hate to see others in pain, and have no tolerance for oppression. They are also very orderly and traditional, leaning heavily on the support of their community and the comfort of their old ways.",
                sizeDescription: "Halflings average about 3 feet tall and weigh about 40 pounds. Your size is Small.",
                sizeCategory: DungeonRace.SizeCategory.Small,
                speed: 25,
                raceSpecificSpells: new List<Spell>(),
                languages: new List<string>
                {
                    "Common",
                    "Halfling"
                }
            ));

            defaultRaces.Add(new DefaultRace(
                name: "Human",
                description:
                "It’s hard to make generalizations about humans, but your human character has these traits.",
                abilities: new Abilities.Abilities(
                    strength: new Ability("Strength", 1),
                    dexterity: new Ability("Dexterity", 1),
                    constitution: new Ability("Constitution", 1),
                    intelligence: new Ability("Intelligence", 1),
                    wisdom: new Ability("Wisdom", 1),
                    charisma: new Ability("Charisma", 1)
                ),
                ageDescription: "Humans reach Adulthood in their late teens and live less than a century.",
                alignmentDescription:
                "Humans tend toward no particular Alignment. The best and the worst are found among them.",
                sizeDescription:
                "Humans vary widely in height and build, from barely 5 feet to well over 6 feet tall. Regardless of your position in that range, your size is Medium.",
                sizeCategory: DungeonRace.SizeCategory.Medium,
                speed: 30,
                raceSpecificSpells: new List<Spell>(),
                languages: new List<string>
                {
                    "Common",
                    "Chosen language"
                }
            ));

            defaultRaces.Add(new DefaultRace(
                name: "Tiefling",
                description: "Tieflings share certain Racial Traits as a result of their Infernal descent.",
                abilities: new Abilities.Abilities(
                    strength: new Ability("Strength", 0),
                    dexterity: new Ability("Dexterity", 0),
                    constitution: new Ability("Constitution", 0),
                    intelligence: new Ability("Intelligence", 1),
                    wisdom: new Ability("Wisdom", 0),
                    charisma: new Ability("Charisma", 2)
                ),
                ageDescription: "Tieflings mature at the same rate as humans but live a few years longer.",
                alignmentDescription:
                "Tieflings might not have an innate tendency toward evil, but many of them end up there. Evil or not, an independent Nature inclines many tieflings toward a chaotic Alignment.",
                sizeDescription: "Tieflings are about the same size and build as humans. Your size is Medium.",
                sizeCategory: DungeonRace.SizeCategory.Medium,
                speed: 30,
                raceSpecificSpells: new List<Spell>(),
                languages: new List<string>
                {
                    "Common",
                    "Infernal"
                },
                darkvisionDescription:
                "Thanks to your Infernal heritage, you have superior vision in dark and dim Conditions. You can see in dim light within 60 feet of you as if it were bright light, and in Darkness as if it were dim light. You can’t discern color in Darkness, only shades of gray."
            ));

            return defaultRaces;
        }
    }

    public class ListOfDefaultRaces : List<DefaultRace>
    {
        public ListOfDefaultRaces()
        {
            foreach(DefaultRace dr in new DefaultRaces().ListofDefaultRaces)
            {
                Add(dr);
            }
        }
    }

    public class DefaultRace
    {
        public string Name;
        public string Description;
        public Abilities.Abilities Abilities;
        public string AgeDescription;
        public string AlignmentDescription;
        public string SizeDescription;
        public DungeonRace.SizeCategory SizeCategory;
        public int Speed;
        public List<Spell> RaceSpecificSpells;
        public List<string> Languages;
        public string DarkvisionDescription;


        public DefaultRace(string name, string description, Abilities.Abilities abilities, 
            string ageDescription, string alignmentDescription, string sizeDescription, 
            DungeonRace.SizeCategory sizeCategory, int speed, List<Spell> raceSpecificSpells, 
            List<string> languages, string darkvisionDescription = "")
        {
            Name = name;
            Abilities = abilities;
            Description = description;
            AgeDescription = ageDescription;
            AlignmentDescription = alignmentDescription;
            SizeDescription = sizeDescription;
            SizeCategory = sizeCategory;
            Speed = speed;
            RaceSpecificSpells = raceSpecificSpells;
            Languages = languages;
            DarkvisionDescription = darkvisionDescription;
        }
    }
}
