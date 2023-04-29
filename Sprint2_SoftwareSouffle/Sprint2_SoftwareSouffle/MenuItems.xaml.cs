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
    /// Interaction logic for MenuItems.xaml
    /// </summary>
    public partial class MenuItems : Window
    {
        public List<String> orderedItems = new List<String>();
        public MenuItems()
        {
            InitializeComponent();
            foodItem1.Visibility = Visibility.Hidden;
            foodItem2.Visibility = Visibility.Hidden;
            foodItem3.Visibility = Visibility.Hidden;
            foodItem4.Visibility = Visibility.Hidden;
            foodItem5.Visibility = Visibility.Hidden;
        }

        private void Appetizers_Click(object sender, RoutedEventArgs e) //displays all appetizer options
        {
            showItems();
            foodItem1.Content = "Chips & Dip";
            foodItem2.Content = "Buffalo Blue Chips";
            foodItem3.Content = "Chicken Nachos";
            foodItem4.Content = "Fried Veggies";
            foodItem5.Content = "Catfish Bites";
        }

        private void Sandwiches_Click(object sender, RoutedEventArgs e) //displays all sandwich options
        {
            showItems();
            foodItem1.Content = "Grilled Cheese";
            foodItem2.Content = "Chicken BLT&A";
            foodItem3.Content = "Cordon Bleu";
            foodItem4.Content = "Philly";
            foodItem5.Content = "Meatball Sub";
        }

        private void Burgers_Click(object sender, RoutedEventArgs e) //displays all burger options
        {
            showItems();
            foodItem1.Content = "J's Burger";
            foodItem2.Content = "Bacon Cheeseburger";
            foodItem3.Content = "Mushroom Swiss";
            foodItem4.Content = "Carolina";
            foodItem5.Content = "Portobello (V)";
        }

        private void Salads_Click(object sender, RoutedEventArgs e) //displays all salad options
        {
            showItems();
            foodItem1.Content = "House";
            foodItem2.Content = "Wedge";
            foodItem3.Content = "Caesar";
            foodItem4.Content = "Sweet Potato Chicken";
            foodItem5.Content = "Chicken";
        }

        private void Drinks_Click(object sender, RoutedEventArgs e) //displays all drink options
        {
            showItems();
            foodItem1.Content = "Coffee";
            foodItem2.Content = "Sweet Tea";
            foodItem3.Content = "Coke";
            foodItem4.Content = "Lemonade";
            foodItem5.Content = "Milk";
        }

        private void showItems()
        {
            foodItem1.Visibility = Visibility.Visible;
            foodItem2.Visibility = Visibility.Visible;
            foodItem3.Visibility = Visibility.Visible;
            foodItem4.Visibility = Visibility.Visible;
            foodItem5.Visibility = Visibility.Visible;
        }

        private void foodItem1_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(foodItem1.Content); //where the item is added to the queue, which is just the console as is stated in the sprint 2 guidelines
            orderedItems.Add(foodItem1.Content.ToString()); //adds the item to a list where it could then be processed by the wait staff in queue form
            Close();
        }

        private void foodItem2_Click(object sender, RoutedEventArgs e) //these methods are all repeats of the first. This should be more streamlined but im not sure how to make a generic reference to the sending button
        {
            Console.WriteLine(foodItem2.Content);
            orderedItems.Add(foodItem2.Content.ToString());
            Close();
        }

        private void foodItem3_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(foodItem3.Content);
            orderedItems.Add(foodItem3.Content.ToString());
            Close();
        }

        private void foodItem4_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(foodItem4.Content);
            orderedItems.Add(foodItem4.Content.ToString());
            Close();
        }

        private void foodItem5_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(foodItem5.Content);
            orderedItems.Add(foodItem5.Content.ToString());
            Close();
        }
    }
}
