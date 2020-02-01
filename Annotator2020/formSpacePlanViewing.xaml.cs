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
    /// Interaction logic for formSpacePlanViewing.xaml
    /// </summary>
    public partial class formSpacePlanViewing : Window
    {
        public formSpacePlanViewing()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {;
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow frm = new MainWindow();
            frm.Show();
        }
    }
}
