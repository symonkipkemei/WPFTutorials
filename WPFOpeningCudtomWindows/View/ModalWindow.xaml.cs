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

namespace WPFOpeningCudtomWindows.View
{
    /// <summary>
    /// Interaction logic for ModalWindow.xaml
    /// </summary>
    public partial class ModalWindow : Window
    {

        public bool Success { get; set; }
        public string Input { get; set; }

        public ModalWindow(Window parentWindow)

        {
            Owner = parentWindow;
            InitializeComponent();
        }

        private void Click_btnOK(object sender, RoutedEventArgs e)
        {
            Success = true;
            Input = txtInput.Text;
            Close();
        }

        private void Click_btnCancel(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Click_textChanged(object sender, TextChangedEventArgs e) 
        {
            if(!string.IsNullOrEmpty(txtInput.Text)) { btnOK.IsEnabled = true; }
            else { btnOK.IsEnabled = false; }

        
        }
    }
}
