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

namespace MiscControls
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

        private void BorderControl_Click(object sender, RoutedEventArgs e)
        {
            BorderControl view = new BorderControl();
            view.Show();
        }

        private void SliderControl_Click(object sender, RoutedEventArgs e)
        {
            SliderControl view = new SliderControl();
            view.Show();
        }

        private void ProgressBar_Click(object sender, RoutedEventArgs e)
        {
            ProgressBar view = new ProgressBar();
            view.Show();
        }

        private void GroupBox_Click(object sender, RoutedEventArgs e)
        {
            GroupBox view = new GroupBox();
            view.Show();
        }

        private void Calendar_Click(object sender, RoutedEventArgs e)
        {
            Calendar view = new Calendar();
            view.Show();
        }
    }
}
