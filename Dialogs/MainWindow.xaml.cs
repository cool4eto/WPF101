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

namespace Dialogs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void btnSimpleMessageBox_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, World!");
        }

        private void btnMessageBoxWithTitle_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, World!", "Angel's App");
        }

        private void btnMessageBoxWithButtons_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, World!", "Angel's App", MessageBoxButton.OKCancel);
        }

        private void btnMessageBoxWithResponse_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Say hello to the program!", "Angel's App", MessageBoxButton.YesNoCancel);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Hi to you too stranger", "Angel's App");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Why are so mean? ", "Angel's App");
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("As you wish", "Angel's App");
                    break;
            }
        }

        private void btnMessageBoxWithIcon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, World!", "Angel's App", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void btnMessageBoxWithDefaultChoice_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, World!", "Angel's App", MessageBoxButton.YesNoCancel, MessageBoxImage.Question, MessageBoxResult.No);
        }
    }
}
