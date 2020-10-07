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
    /// Interaction logic for ListBoxControl.xaml
    /// </summary>
    public partial class ListBoxControl : Window
    {
        public ListBoxControl()
        {
            InitializeComponent();
            List<ToDoItem> items = new List<ToDoItem>();
            items.Add(new ToDoItem { Title = "Complete this WPF tutorial", Completion = 60 });
            items.Add(new ToDoItem() { Title = "Learn C#", Completion = 80 });
            items.Add(new ToDoItem() { Title = "Wash the car", Completion = 0 });
            items.Add(new ToDoItem() { Title = "Learn C# Asp.Net", Completion = 60 });

            toDoList.ItemsSource = items;
        }

        private void btnShowSelectedItem_Click(object sender, RoutedEventArgs e)
        {
            string titles = "";
            foreach (var item in toDoList.SelectedItems)
            {
                titles += $"{((item as ToDoItem).Title)} \n";
            }
            MessageBox.Show(titles.ToString(), "Selected Items");
        }

        private void btnSelectLast_Click(object sender, RoutedEventArgs e)
        {
            toDoList.SelectedIndex = toDoList.Items.Count - 1;
        }

        private void btnSelectNext_Click(object sender, RoutedEventArgs e)
        {
            var newIndex = toDoList.SelectedIndex + 1;
            if (newIndex >= toDoList.Items.Count)
                newIndex = 0;

            toDoList.SelectedIndex = newIndex;
        }

        private void btnSelectCSharp_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in toDoList.Items)
            {
                if ((item as ToDoItem).Title.Contains("C#"))
                    toDoList.SelectedItems.Add(item);
            }
        }

        private void btnSelectAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in toDoList.Items)
            {
                toDoList.SelectedItems.Add(item);
            }
        }

        private void toDoList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (toDoList.SelectedItem != null)
                this.Title = (toDoList.SelectedItem as ToDoItem).Title;
        }
    }
}
