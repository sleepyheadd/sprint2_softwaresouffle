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
        public Window1()
        {
            InitializeComponent();
            AddToOrder.Visibility = Visibility.Hidden;
            RemoveFromOrder.Visibility = Visibility.Hidden;
            CloseMenu.Visibility = Visibility.Hidden;
        }

        private void OpenMenu(object sender, RoutedEventArgs e) //shows options for the table
        {
            AddToOrder.Visibility = Visibility.Visible;
            RemoveFromOrder.Visibility = Visibility.Visible;
            CloseMenu.Visibility = Visibility.Visible;
        }

        private void AddToOrder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseMenu_Click(object sender, RoutedEventArgs e) //hides option for the table
        {
            AddToOrder.Visibility = Visibility.Hidden;
            RemoveFromOrder.Visibility = Visibility.Hidden;
            CloseMenu.Visibility = Visibility.Hidden;
        }
    }
}
