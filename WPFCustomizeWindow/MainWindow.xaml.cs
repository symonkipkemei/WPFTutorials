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

namespace WPFCustomizeWindow
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

        private void Click_leftButtonDown(object sender, RoutedEventArgs e)
        {
            DragMove();
        }

        private void Click_btnClose(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Click_btnMaximize(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            { WindowState = WindowState.Normal; }
            else { WindowState = WindowState.Maximized;}
        }

        private void Click_btnMinimize(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }


    }
}

