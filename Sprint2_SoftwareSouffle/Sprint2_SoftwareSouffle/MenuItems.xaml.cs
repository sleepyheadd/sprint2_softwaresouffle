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
        public static List<String> orderedItems = new List<String>();
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
            menuItems chipDip = new menuItems("Chips & Dip", 8);
            menuItems blueChips = new menuItems("Buffalo Blue Chips", 6);
            menuItems chickenNachos = new menuItems("Chicken Nachos", 8.5f);
            menuItems friedVeggies = new menuItems("Fried Veggies", 6.5f);
            menuItems catBites = new menuItems("Catfish Bites", 6.5f);

            updateItems(chipDip, blueChips, chickenNachos, friedVeggies, catBites);
        }

        private void Sandwiches_Click(object sender, RoutedEventArgs e) //displays all sandwich options
        {
            menuItems grilledCheese = new menuItems("GrilledCheese", 5.5f);
            menuItems chickenBLT = new menuItems("Chicken BLT&A", 10);
            menuItems cordonBleu = new menuItems("Cordon Bleu", 11);
            menuItems philly = new menuItems("Philly", 13.5f);
            menuItems meatballSub = new menuItems("Meatball Sub", 10f);

            updateItems(grilledCheese, chickenBLT, cordonBleu, philly, meatballSub);
        }

        private void Burgers_Click(object sender, RoutedEventArgs e) //displays all burger options
        {
            menuItems jBurger = new menuItems("J's Burger", 10);
            menuItems baconBurger = new menuItems("Bacon Cheeseburger", 11);
            menuItems mushSwiss = new menuItems("Mushroom Swiss", 11);
            menuItems carolina = new menuItems("Carolina", 11);
            menuItems portobello = new menuItems("Portobello (V)", 8.5f);

            updateItems(jBurger, baconBurger, mushSwiss, carolina, portobello);
        }

        private void Salads_Click(object sender, RoutedEventArgs e) //displays all salad options
        {
            menuItems house = new menuItems("House", 10);
            menuItems wedge = new menuItems("Wedge", 10);
            menuItems caesar = new menuItems("Caesar", 10);
            menuItems sPC = new menuItems("Sweet Potato Chicken", 10);
            menuItems chicken = new menuItems("Chicken", 10);

            updateItems(house, wedge, caesar, sPC, chicken);
        }

        private void Drinks_Click(object sender, RoutedEventArgs e) //displays all drink options
        {
            menuItems coffee = new menuItems("Coffee", 2);
            menuItems sweetTea = new menuItems("Sweet Tea", 2);
            menuItems coke = new menuItems("Coke", 2);
            menuItems lemonade = new menuItems("Lemonade", 2);
            menuItems milk = new menuItems("Milk", 2);

            updateItems(coffee, sweetTea, coke, lemonade, milk);
        }

        private void updateItems(menuItems item1, menuItems item2, menuItems item3, menuItems item4, menuItems item5) //updates button names and prices
        {
            showItems();
            foodItem1.Content = item1.name;
            pricing1.Content = item1.price;
            foodItem2.Content = item2.name;
            pricing2.Content = item2.price;
            foodItem3.Content = item3.name;
            pricing3.Content = item3.price;
            foodItem4.Content = item4.name;
            pricing4.Content = item4.price;
            foodItem5.Content = item5.name;
            pricing5.Content = item5.price;
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
