using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class Gendarme : Archetype
    {
        public Gendarme(Classes.Cavalier cavalier)
        {
            Name = "Gendarme";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Bonus Feat",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Tactician, cavalier.GreaterTactician, cavalier.MasterTactician },
                },
                new ArchetypeAbility
                {
                    Name = "Transfixing Charge",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.SupremeCharge },
                }
            };

            for (int i = 5; i <= 20; i += 3)
                ArchetypeAbilities.Add(new ArchetypeAbility
                {
                    Name = "Bonus Feat",
                    Level = i,
                });
        }
    }
}
