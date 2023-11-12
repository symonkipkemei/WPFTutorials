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

namespace WPFCustomTextboxControl.View
{
    /// <summary>
    /// Interaction logic for ClearableTextBox.xaml
    /// </summary>
    public partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private string placeholder;

        public string Placeholder
        {
            get { return placeholder; }
            set 
            { 
                placeholder = value; 

                // do not use this 
                // we will use a property onchain 
                tbPlaceholder.Text = placeholder;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)


        {
            // clears the typed text input in the box
            txtInput.Clear();

            //put the cursor back into the text box
            txtInput.Focus();
        }


        // method below clears the texblock the moment the textbox changes and returns it when null
        private void txtInput_TextChanged(object sender, TextChangedEventArgs e) 
        { 
            if (string.IsNullOrEmpty(txtInput.Text)) 
            { tbPlaceholder.Visibility = Visibility.Visible; }
            else
            { tbPlaceholder.Visibility = Visibility.Hidden;}
        }
    }
}
