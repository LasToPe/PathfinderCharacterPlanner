using GalaSoft.MvvmLight;
using PathfinderModelling.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.ViewModels
{
    public class ArchetypeSelectorDialogViewModel : ViewModelBase
    {
        public CharacterClass Class { get; set; }
        public List<Archetype> Archetypes => Class.Archetypes;
    }
}
