using MaterialDesignThemes.Wpf;
using Microsoft.Extensions.DependencyInjection;
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
using UI.ViewModels;

namespace UI.Dialogs
{
    /// <summary>
    /// Interaction logic for ArchetypeSelectorDialog.xaml
    /// </summary>
    public partial class ArchetypeSelectorDialog : UserControl
    {
        public ArchetypeSelectorDialog()
        {
            InitializeComponent();
        }

        private Archetype _archetype = null;

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _archetype = (sender as ListView).SelectedItem as Archetype;
        }

        private void ApplyArchetype_Click(object sender, RoutedEventArgs e)
        {
            if (_archetype != null)
            {
                try
                {
                    (DataContext as ArchetypeSelectorDialogViewModel).Class.AddArchetype(_archetype);
                    App.ServiceProvider.GetRequiredService<MainWindowViewModel>().UpdateCharacterLevels();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            DialogHost.Close("Main");
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogHost.Close("Main");
        }
    }
}
