using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cleric
{
    class AngelfireApostle : Archetype
    {
        public AngelfireApostle(Classes.Cleric cleric)
        {
            Name = "Angelfire Apostle";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Diminished Spellcasting",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.Spells },
                    Add = () => cleric.DiminishedSpellCasting(true),
                    Remove = () => cleric.DiminishedSpellCasting(false)
                },
                new ArchetypeAbility
                {
                    Name = "Extra Channel",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Versatile Healing Channel",
                    Level = 5,
                },
                new ArchetypeAbility
                {
                    Name = "Cleansing Flames",
                    Level = 9,
                }
            };

            ArchetypeAbilities.AddRange(cleric.ClassAbilities
                .Where(a => a.Name.Contains("Channel Energy"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Channel Energy", "Channel Angelfire"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
