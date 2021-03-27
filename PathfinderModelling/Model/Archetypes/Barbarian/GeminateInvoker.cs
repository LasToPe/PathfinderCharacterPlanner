using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class GeminateInvoker : Archetype
    {
        public GeminateInvoker(Classes.Barbarian barbarian)
        {
            Name = "Geminate Invoker";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Contemplative",
                    Level = 1,
                    Add = () => barbarian.Alignment = "Any Neutral",
                    Remove = () => barbarian.Alignment = "Any Nonlawful",
                },
                new ArchetypeAbility
                {
                    Name = "Trance",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.Rage }
                },
                new ArchetypeAbility
                {
                    Name = "Spirit Conduit",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.RagePower4, barbarian.RagePower8, barbarian.RagePower12 }
                }
            };

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Trap Sense"))
                .Select(a => new ArchetypeAbility
                {
                    Name = $"Haunt Channeler {a.Level / 3}d6",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
