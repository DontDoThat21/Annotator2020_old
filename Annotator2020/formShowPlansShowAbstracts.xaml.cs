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
    /// Interaction logic for formShowPlansShowAbstracts.xaml
    /// </summary>
    public partial class formShowPlansShowAbstracts : Window
    {
        public formShowPlansShowAbstracts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void imageHelp_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("This will be a web control most likely displaying a tennet-global GPJ/Proj help document. (Jira maybe?) WIP.");
        }

        private void imageFilter_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("This needs to filter the data returned in the below grid. WIP.");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow frm = new MainWindow();
            frm.Show();
        }
    }
}
