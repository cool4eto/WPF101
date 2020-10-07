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

namespace RichControls
{
    /// <summary>
    /// Interaction logic for FlowDocumentScrollViewerCodeBehind.xaml
    /// </summary>
    public partial class FlowDocumentScrollViewerCodeBehind : Window
    {
        public FlowDocumentScrollViewerCodeBehind()
        {
            InitializeComponent();

            FlowDocument document = new FlowDocument();

            Paragraph p = new Paragraph(new Run("Hello, world!"));
            p.FontSize = 36;
            document.Blocks.Add(p);

            p = new Paragraph(new Run("You are the ultimate programmer!!!!"));
            p.FontSize = 14;
            p.FontStyle = FontStyles.Italic;
            p.TextAlignment = TextAlignment.Left;
            p.Foreground = Brushes.Gray;
            document.Blocks.Add(p);

            fdViewer.Document = document;
        }
    }
}
