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
            lItems[0].AddItemOnStore(10);
            lItems[1].AddItemOnStore(12);



        }



        private void SellButton_Click(object sender, RoutedEventArgs e)
        {
            int N = int.Parse(ItemNumber.Text);
            Item sItem = ItemsListBox.SelectedItem as Item;
            sItem.SellItem(N);
            ItemsListBox.SelectedItem = sItem;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            int N = int.Parse(ItemNumber.Text);
            Item sItem = ItemsListBox.SelectedItem as Item;
            sItem.AddItemOnStore(N);
            ItemsListBox.SelectedItem = sItem;
        }

        private void AddNewItemButton_Click(object sender, RoutedEventArgs e)
        {
            lItems.Add(new Item(NewItemNameBox.Text, lItems.Count));
            ItemsListBox.ItemsSource = lItems;
        }
    }
}
