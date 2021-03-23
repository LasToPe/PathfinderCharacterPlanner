using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model
{
    public class ArchetypeAbility : ClassAbility
    {
        public List<ClassAbility> ReplacedAbilities { get; set; } = new List<ClassAbility>();
        public Action Add { get; set; }
        public Action Remove { get; set; }
    }
}
