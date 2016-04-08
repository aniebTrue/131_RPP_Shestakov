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

namespace StoreApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Item> lItems = new List<Item>();
        public MainWindow()
        {
            InitializeComponent();
            lItems.Add(new Item("CPU", 1));
            lItems.Add(new Item("GPU", 2));
            lItems.Add(new Item("RAM", 3));
            ItemsListBox.ItemsSource = lItems;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String Name = NewItemNameBox.Text;
            lItems.Add(new Item(Name, lItems.Last().ItemID+1));
        }
    }
}
