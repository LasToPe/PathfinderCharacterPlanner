using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class SpeakerOfThePalatineEye : Archetype
    {
        public SpeakerOfThePalatineEye(Classes.Bard bard)
        {
            Name = "Speaker of the Palatine Eye";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Angelic Grace",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Spells",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Spells },
                },
                new ArchetypeAbility
                {
                    Name = "Corpse Speaker",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Countersong },
                },
                new ArchetypeAbility
                {
                    Name = "Keen Ritualist",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { bard.JackOfAllTrades },
                }
            };
        }
    }
}
