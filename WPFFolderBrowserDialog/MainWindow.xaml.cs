using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WinForms = System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFFolderBrowserDialog
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

        ///method to interact with the click button
        ///
        private void Click_btnPressMe(object sender, RoutedEventArgs e)
        {
            //Instantiate an object
            WinForms.FolderBrowserDialog dialog = new WinForms.FolderBrowserDialog();

            dialog.InitialDirectory = "D:\\FORMODE HARDRIVE\\FORMODE\\ACTIVE PROJECTS";
            WinForms.DialogResult result = dialog.ShowDialog();

            if(result == WinForms.DialogResult.OK)
            {
                string folder = dialog.SelectedPath;
            }
        }
    }
}
