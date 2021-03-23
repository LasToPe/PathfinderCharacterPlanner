using PathfinderModelling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;
using UI.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using UI.Dialogs;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel _vm;
        public MainWindow()
        {
            InitializeComponent();
            _vm = DataContext as MainWindowViewModel;
        }

        private void Class_Changed(object sender, SelectionChangedEventArgs e)
        {
            var combo = sender as ComboBox;
            var cl = combo.DataContext as CharacterLevel;
            cl.Class = combo.SelectedItem as CharacterClass;

            _vm.UpdateCharacterLevels();
        }

        private void Grid_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            Viewer.ScrollToVerticalOffset(Viewer.VerticalOffset - e.Delta);
        }

        private void AddArchetype_Click(object sender, RoutedEventArgs e)
        {
            var @class = (sender as Button).DataContext as CharacterClass;
            App.ServiceProvider.GetRequiredService<ArchetypeSelectorDialogViewModel>().Class = @class;
            Main.ShowDialog(new ArchetypeSelectorDialog());
        }

        private void RemoveArchetype_Click(object sender, RoutedEventArgs e)
        {
            var characterClass = (sender as Button).CommandParameter as CharacterClass;
            var archetype = (sender as Button).DataContext as Archetype;

            try
            {
                characterClass.RemoveArchetype(archetype);
                _vm.RaisePropertyChanged(null);
                _vm.UpdateCharacterLevels();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetClass_Click(object sender, RoutedEventArgs e)
        {
            var level = ((sender as FrameworkElement).DataContext as CharacterLevel).Level;
            Main.ShowDialog(new ClassSelectorDialog(level));
        }

        private void SetAllLevels_Click(object sender, RoutedEventArgs e)
        {
            var @class = (sender as Button).DataContext as CharacterClass;
            foreach (var cl in _vm.CharacterLevels)
            {
                cl.Class = @class;
            }
            _vm.UpdateCharacterLevels();
        }

        private void ViewSpellCasting_Click(object sender, RoutedEventArgs e)
        {
            App.ServiceProvider.GetService<SpellsViewDialogViewModel>().Class = (sender as Button).DataContext as CharacterClass;
            Main.ShowDialog(new SpellsViewDialog());
        }
    }
}
