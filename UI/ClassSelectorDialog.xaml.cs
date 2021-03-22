using MaterialDesignThemes.Wpf;
using PathfinderModelling.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI
{
    /// <summary>
    /// Interaction logic for ClassSelectorDialog.xaml
    /// </summary>
    public partial class ClassSelectorDialog : UserControl
    {
        private int _level;
        public ClassSelectorDialog(int level, object dataContext)
        {
            InitializeComponent();
            _level = level;
            DataContext = dataContext;
        }

        private CharacterClass _characterClass = null;

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _characterClass = (sender as ListView).SelectedValue as CharacterClass;
        }

        private void SetClass_Click(object sender, RoutedEventArgs e)
        {
            if (_characterClass != null)
            {
                (DataContext as MainWindowViewModel).CharacterLevels[_level - 1].Class = _characterClass;
                (DataContext as MainWindowViewModel).UpdateCharacterLevels();
            }

            DialogHost.Close("Main");
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogHost.Close("Main");
        }
    }
}
