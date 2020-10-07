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

namespace ListControls
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

        private void ItemsControl_Click(object sender, RoutedEventArgs e)
        {
            ItemsControl view = new ItemsControl();
            view.Show();
        }

        private void ListBoxControl_Click(object sender, RoutedEventArgs e)
        {
            ListBoxControl view = new ListBoxControl();
            view.Show();
        }

        private void ComboBoxControl_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxControl view = new ComboBoxControl();
            view.Show();
        }
    }
}
