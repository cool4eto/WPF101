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

namespace TabControl
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

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            var newIndex = TabControlSample.SelectedIndex - 1;
            if (newIndex < 0)
                newIndex = TabControlSample.Items.Count - 1; // So that it just scrolls trhough the items

                TabControlSample.SelectedIndex = newIndex;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            var newIndex = TabControlSample.SelectedIndex + 1;
            if (newIndex >= TabControlSample.Items.Count)
                newIndex = 0;

            TabControlSample.SelectedIndex = newIndex;
        }

        private void Current_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Selected tab: " + (TabControlSample.SelectedItem as TabItem).Header);
        }
    }
}
