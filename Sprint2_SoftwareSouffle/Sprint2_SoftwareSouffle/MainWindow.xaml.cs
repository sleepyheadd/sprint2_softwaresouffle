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

namespace Sprint2_SoftwareSouffle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<String> usernameStorage = new List<String>();
        public static List<String> passwordStorage = new List<String>();
        public static String loggedInUsername;
        public MainWindow()
        {
            InitializeComponent();

            //initializing profiles
            //wait staffer 1
            usernameStorage.Add("waitstaff1"); passwordStorage.Add("password1");
            usernameStorage.Add("waitstaff2"); passwordStorage.Add("password2");
            usernameStorage.Add("waitstaff3"); passwordStorage.Add("password3");
            usernameStorage.Add("waitstaff4"); passwordStorage.Add("password4");
            usernameStorage.Add("waitstaff5"); passwordStorage.Add("password5");
            usernameStorage.Add("cook1"); passwordStorage.Add("password6");
            usernameStorage.Add("cook2"); passwordStorage.Add("password7");
            usernameStorage.Add("cook3"); passwordStorage.Add("password8");
            usernameStorage.Add("manager1"); passwordStorage.Add("password9");
            usernameStorage.Add("manager2"); passwordStorage.Add("password10");
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            String tempUsername = username.Text;
            String tempPassword = password.Text;
            bool isValidLogin = usernameStorage.Contains(tempUsername) && passwordStorage[usernameStorage.IndexOf(tempUsername)] == tempPassword; //determines whether the username and password combo exist

            if (isValidLogin && tempUsername.Substring(0, tempUsername.Length - 1) == "manager")  //if its a valid login and a manager account, load manager screen 
            {
                loggedInUsername = tempUsername;
                managerScreen managerPage = new managerScreen();
                managerPage.Show();
                Close();
            } else if (isValidLogin) //if its a valid login but not a manager, load the table screen
            {
                loggedInUsername = tempUsername;
                Window1 tablePage = new Window1();
                tablePage.Show();
                Close();
            } else { loginError.Content = "Invalid login!"; }
        }
        
    }
}
