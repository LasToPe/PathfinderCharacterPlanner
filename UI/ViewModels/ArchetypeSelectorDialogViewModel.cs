using GalaSoft.MvvmLight;
using PathfinderModelling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.ViewModels
{
    public class ArchetypeSelectorDialogViewModel : ViewModelBase
    {
        public CharacterClass Class { get; set; }
        private List<Archetype> Archetypes => Class.Archetypes;
        public List<Archetype> AvailableArcheTypes
        {
            get
            {
                var list = new List<Archetype>();
                foreach (var a in Archetypes)
                {
                    if (a.ArchetypeAbilities.SelectMany(a => a.ReplacedAbilities).All(a => Class.ClassAbilities.Contains(a)))
                    {
                        list.Add(a);
                    }
                }
                return list;
            }
        }
    }
}
