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
using System.Windows.Shapes;

namespace Sprint2_SoftwareSouffle
{
    /// <summary>
    /// Interaction logic for cookMenu.xaml
    /// </summary>
    public partial class cookMenu : Window
    {
        public cookMenu()
        {
            InitializeComponent();
            for (int i = 0; i < MenuItems.orderedItems.Count; i++)
            {
                orderedList.Content += MenuItems.orderedItems[i] + "\n";
            }
        }

        private void Logout_Click(object sender, RoutedEventArgs e) //goes back to the main menu
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
