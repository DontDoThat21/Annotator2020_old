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
using System.Windows.Shapes;

namespace Annotator2020
{
    /// <summary>
    /// Interaction logic for formEmailNotifyTeam.xaml
    /// </summary>
    public partial class formEmailNotifyTeam : Window
    {
        public formEmailNotifyTeam()
        {
            InitializeComponent();
        }

        private void radioChecked(object sender, RoutedEventArgs e)
        {
            RadioButton btn = (RadioButton)sender;
            if (btn.Content.ToString() == "Client-based (Typ)")
            {
                lblSelectShowOrProject.Visibility = Visibility.Hidden;
                cboSelectShowOrProject.Visibility = Visibility.Hidden;
            }
            else if(btn.Content.ToString() == "Client/Show-based")
            {
                lblSelectShowOrProject.Visibility = Visibility.Visible;
                cboSelectShowOrProject.Visibility = Visibility.Visible;
            }
            else if(btn.Content.ToString() == "Project-Based")
            {
                lblSelectShowOrProject.Visibility = Visibility.Visible;
                cboSelectShowOrProject.Visibility = Visibility.Visible;
            }
        }

        private void imageFilter_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("GPJ Annotator Email-Notification Teams are ClientCode-based by default. Teams can be ClientShow or Project-Based by selecting one of those options.\n" +
                "To add an Employee to a Team, either type their name in the noted field, and press <ENTER> on your keyboard, OR... from the lists on the left, select all members to be added to the Team." +
                "Then, click 'ADD TO TEAM' to include the highlighted person(s) on the team list.\n" +
                "To remove a Team member, select 'REMOVE', then click on the member to the Team list to remove.", "Email-Notification Team Setup Help", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow frm = new MainWindow();
            frm.Show();
        }
    }
}
