using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cleric
{
    class Crusader : Archetype
    {
        public Crusader(Classes.Cleric cleric)
        {
            Name = "Crusader";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Diminished Spellcasting",
                    Level = 1,
                    Add = () => cleric.DiminishedSpellCasting(true),
                    Remove = () => cleric.DiminishedSpellCasting(false),
                },
                new ArchetypeAbility
                {
                    Name = "Bonus Feat",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Legion's Blessing",
                    Level = 1,
                }
            };

            for (int i = 5; i <= 20; i += 5)
                ArchetypeAbilities.Add(new ArchetypeAbility
                {
                    Name = "Bonus Feat",
                    Level = i,
                });
        }
    }
}
