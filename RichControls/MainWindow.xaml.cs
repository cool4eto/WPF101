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

namespace RichControls
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FlowDocumentScrollViewer_Click(object sender, RoutedEventArgs e)
        {
            FlowDocumentScrollViewer view = new FlowDocumentScrollViewer();
            view.Show();
        }

        private void FlowDocumentPageViewer_Click(object sender, RoutedEventArgs e)
        {
            FlowDocumentPageViewer view = new FlowDocumentPageViewer();
            view.Show();
        }

        private void FlowDocumentReader_Click(object sender, RoutedEventArgs e)
        {
            FlowDocumentReader flowDocumentReader = new FlowDocumentReader();
            flowDocumentReader.Show();
        }

        private void FlowDocumentScrollViewerCodeBehind_Click(object sender, RoutedEventArgs e)
        {
            FlowDocumentScrollViewerCodeBehind view = new FlowDocumentScrollViewerCodeBehind();
            view.Show();
        }

        private void RichTextBox_Click(object sender, RoutedEventArgs e)
        {
            RichTextBox view = new RichTextBox();
            view.Show();
        }
    }
}
