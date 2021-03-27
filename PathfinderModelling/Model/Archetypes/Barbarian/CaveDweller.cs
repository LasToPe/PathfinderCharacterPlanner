using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class CaveDweller : Archetype
    {
        public CaveDweller(Classes.Barbarian barbarian)
        {
            Name = "Cave Dweller";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Tight Tunnels",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.FastMovement }
                },
            };

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Trap Sense"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Trap Sense", "Tunnel Vision"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Damage Reduction"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Damage Reduction", "Sun Walker").Replace("/-", ""),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
