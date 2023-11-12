using Microsoft.Win32;
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

namespace WPFOpenFileDialog
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

        private void Click_btnOpen(object sender, RoutedEventArgs e)
        {
            // intantiatieas a new openfiledialog object
            OpenFileDialog fileDialog = new OpenFileDialog();

            // filters through to just select the revit files
            fileDialog.Filter = " Revit Files | *.rvt";

            // set intial category that the folder can open from
            fileDialog.InitialDirectory = "D:\\FORMODE HARDRIVE\\FORMODE\\ACTIVE PROJECTS";

            fileDialog.Title = "Please select a rvt file";
            fileDialog.Multiselect = true;

            // note that bool? allows you to have 3 values
            bool? success = fileDialog.ShowDialog();

            // defining the path and the filename
            string path = fileDialog.FileName;
            string fileName = fileDialog.SafeFileName;


            if (success == true) 
            { 
                tbMessage.Text = fileName;
            }
            
            else if (success == false) 
            {
                tbMessage.Text = "No file was selected";
            }
            else 
            {
                tbMessage.Text = "Null";
            }

        }
    }
}
