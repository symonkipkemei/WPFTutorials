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

namespace WPFMessageBox
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

        public void Click_btnPressMe(object sender, RoutedEventArgs e)
        {
            // Add messages to the list
            List<string> messages = new List<string>();
            messages.Add("Hey handsome");
            messages.Add("Hey Mpoa");
            messages.Add("Hey My pillar of strength!");
            messages.Add("Hey my love!");


            // abstract random message into the list
            Random randomMessage = new Random();
            int ran = randomMessage.Next(0, messages.Count);

            // initiates a message box 
            // a modo, you have to close to move to the next
            // MessageBox.Show(messages[ran]);MessageBox.Show(messages[ran], "Error!", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            MessageBoxResult message = MessageBox.Show("Do you love me?", "Tell me!",MessageBoxButton.YesNo, MessageBoxImage.Question );
            
            if (message == MessageBoxResult.Yes) 
            { 
                tbMessage.Text = messages[ran];
            }
            else
            {
                tbMessage.Text = "I hate you!";
            }
        }
    }   
}
