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
        List<String> usernameStorage = new List<String>();
        List<String> passwordStorage = new List<String>();
        public MainWindow()
        {
            InitializeComponent();

            //initializing profiles
            //wait staffer 1
            usernameStorage.Add("waitstaff1"); passwordStorage.Add("password1");
            usernameStorage.Add("waitstaff2"); passwordStorage.Add("password2");
            usernameStorage.Add("waitstaff3"); passwordStorage.Add("password3");
            usernameStorage.Add("waitstaff4"); passwordStorage.Add("password4");
            usernameStorage.Add("manager"); passwordStorage.Add("password5");
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            String tempUsername = username.Text;
            String tempPassword = password.Text;
            bool isValidLogin = usernameStorage.Contains(tempUsername) && passwordStorage[usernameStorage.IndexOf(tempUsername)] == tempPassword; //determines whether the username and password combo exist

            if (isValidLogin) { /* go to next menu */ }
            else { loginError.Content = "Invalid login!"; }
        }
    }
}
