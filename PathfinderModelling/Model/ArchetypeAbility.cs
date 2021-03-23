using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model
{
    public class ArchetypeAbility : ClassAbility
    {
        public List<ClassAbility> ReplacedAbilities { get; set; }        
    }
}
