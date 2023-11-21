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
using System.ComponentModel;

namespace WPFDataBindingGirls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        //declare a property to hold our date
        private string madame;

        public string Madame
        {
            get { return madame; }
            set {
                madame = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Madame"));
            }
        }

        //constructor
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();

        }


        //methods on click of a button

        private void btPop_Click(object sender, RoutedEventArgs e)
        {
            box.Text = tbFirstName.Text + tbSecondName.Text + "Dinywa_" + tbAge.Text;
           

         }

    }

}