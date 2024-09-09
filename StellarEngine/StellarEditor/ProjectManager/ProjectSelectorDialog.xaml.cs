using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace StellarEditor.ProjectManager
{
    /// <summary>
    /// Lógica de interacción para ProjectSelectorDialog.xaml
    /// </summary>
    public partial class ProjectSelectorDialog : Window
    {
        public ProjectSelectorDialog()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, RoutedEventArgs e)
        {
            if (sender == newProjectButton)
            {
                if (newProjectButton.Content.ToString()== "New Project")
                {
                    newProjectButton.Content = "Open project";
                    openProjectScreen.Visibility = Visibility.Collapsed;
                    newProjectButton.IsChecked = true;
                }
                else 
                {
                    newProjectButton.IsChecked = false;
                    openProjectScreen.Visibility = Visibility.Visible;
                    newProjectButton.Content = "New Project";
                }
            }
        }
    }
}
