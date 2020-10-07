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

namespace ListControls
{
    /// <summary>
    /// Interaction logic for ItemsControl.xaml
    /// </summary>
    public partial class ItemsControl : Window
    {
        public ItemsControl()
        {
            InitializeComponent();
            List<ToDoItem> items = new List<ToDoItem>();
            items.Add(new ToDoItem { Title = "Complete this WPF tutorial", Completion = 60 });
            items.Add(new ToDoItem() { Title = "Learn C#", Completion = 80 });
            items.Add(new ToDoItem() { Title = "Wash the car", Completion = 0 });

            toDoList.ItemsSource = items;
        }
    }
}
