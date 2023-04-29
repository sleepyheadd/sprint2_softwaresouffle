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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        Button activeTable;
        public Window1()
        {
            InitializeComponent();
            tablesResponsibleFor.Content = MainWindow.loggedInUsername + " is responsible for tables 1-8"; //lets the employee know what tables they are responsible for

            AddToOrder.Visibility = Visibility.Hidden; //starts out by hiding the options menu
            SetTableStatus.Visibility = Visibility.Hidden;
            CloseMenu.Visibility = Visibility.Hidden;
        }

        private void OpenMenu(object sender, RoutedEventArgs e) //shows options for the table
        {
            activeTable = sender as Button;
            AddToOrder.Visibility = Visibility.Visible;
            SetTableStatus.Visibility = Visibility.Visible;
            CloseMenu.Visibility = Visibility.Visible;
        }

        private void AddToOrder_Click(object sender, RoutedEventArgs e)
        {
            MenuItems menuPage = new MenuItems();
            menuPage.Show();

            managerScreen.mostRecentActivity = MainWindow.loggedInUsername + " ordered an item to a table."; //Updates the "Most Recent Activity" part of the manager menu.
        }

        private void CloseMenu_Click(object sender, RoutedEventArgs e) //hides option for the table
        {
            AddToOrder.Visibility = Visibility.Hidden;
            SetTableStatus.Visibility = Visibility.Hidden;
            CloseMenu.Visibility = Visibility.Hidden;
        }

        private void SetTableStatus_Click(object sender, RoutedEventArgs e) //changes the color of the table based on what the table color already is
        {
            managerScreen.mostRecentActivity = MainWindow.loggedInUsername + " changed a table's status."; //Updates the "Most Recent Activity" part of the manager menu.

            if (activeTable.Background.ToString() == "#FFB7FFBA") { activeTable.Background = new SolidColorBrush(Color.FromArgb(255,255,255,183)); }
            else if (activeTable.Background.ToString() == "#FFFFFFB7") { activeTable.Background = new SolidColorBrush(Color.FromArgb(255, 255, 116, 116)); }
            else { activeTable.Background = new SolidColorBrush(Color.FromArgb(255, 183, 255, 186)); }
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
