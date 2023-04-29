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
    public partial class managerScreen : Window
    {
        public managerScreen()
        {
            InitializeComponent();
        }

        private void createProfile_Click(object sender, RoutedEventArgs e)
        {
            if ((newUsername.Text != "" && newPassword.Text != "") && !MainWindow.usernameStorage.Contains(newUsername.Text)) //Makes sure the new profile values aren't blank or the profile doesnt already exist
            {
                MainWindow.usernameStorage.Add(newUsername.Text); MainWindow.passwordStorage.Add(newPassword.Text);
                accountAdded.Content = "Account added!";
            } else { accountAdded.Content = "Invalid account"; }
        }

        private void modifyButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.usernameStorage.Contains(modifyUsername.Text))
            {
                MainWindow.passwordStorage[MainWindow.usernameStorage.IndexOf(modifyUsername.Text)] = newModifiedPassword.Text; //changes password of given account if it exists
                accountModified.Content = "Password updated!";
            } else
            {
                accountModified.Content = "Invalid account!";
            }
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
