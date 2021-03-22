using GalaSoft.MvvmLight;
using PathfinderModelling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.ViewModels
{
    public class ClassSelectorDialogViewModel : ViewModelBase
    {
        public static List<CharacterClass> Classes { get; private set; }

        public ClassSelectorDialogViewModel()
        {
            var classes = new List<CharacterClass>();
            var types = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(a => a.GetName().Name == "PathfinderModelling").ExportedTypes.Where(t => t.Namespace == "PathfinderModelling.Model.Classes");
            foreach (var type in types)
                classes.Add(Activator.CreateInstance(type) as CharacterClass);
            Classes = classes;
        }
    }
}
