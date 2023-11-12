using System.Windows;
using WPFOpeningCudtomWindows.View;

namespace WPFOpeningCudtomWindows
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

        private void Click_btnNormal(object sender, RoutedEventArgs e)
        {
            NormalWindow normalWindow = new NormalWindow();
            // window can show parallel to the main window
            normalWindow.Show();

        }

        private void Click_btnModal(object sender, RoutedEventArgs e) 
        { 
            ModalWindow modalWindow = new ModalWindow(this);

            // you cannot do anything until the second window is closed
            Opacity = 0.4;
            modalWindow.ShowDialog();
            Opacity = 1;
            if (modalWindow.Success) 
            { 
               txInput.Text = modalWindow.Input;
            }
        
        }
    }
}
