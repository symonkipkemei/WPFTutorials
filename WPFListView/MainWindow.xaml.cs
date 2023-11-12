using System;
using System.Collections;
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

namespace WPFListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lvEntries.Items.Add("Kipkemei");
            lvEntries.Items.Add("Kipchumba");
            lvEntries.Items.Add("Symon");
        }

        private void Click_btnAdd(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(tbName.Text);
        }

        private void Click_btnDelete(object sender, RoutedEventArgs e) 
        {
            //delete all entries by selecting one item
            var items = lvEntries.SelectedItems;
            var outcome = MessageBox.Show($"Are you sure you wan to delete: {items.Count}","Warning",MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (outcome == MessageBoxResult.Yes) 
            {

                var itemList = new ArrayList(items);
                foreach (var item in itemList)
                {
                    lvEntries.Items.Remove(item);

                }

            }

            
    
        }

        private void Click_btnClear(object sender, RoutedEventArgs e) 
        { 
            // clear all the entries in the list
            lvEntries.Items.Clear();
        
        }
    }
}
