using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model
{
    public class Archetype
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<ArchetypeAbility> ArchetypeAbilities { get; set; }
    }
}
