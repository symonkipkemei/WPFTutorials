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

namespace WPFDataBindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // an object defined at a class level

        Person _person = new Person()
        {
            Name = "symon",
            Email = "symonkipkemei@gmail.com",
            Address = "30400",
            Number = 0718454749
        };


        // constructor

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = _person;
        }


        // a method to define the click functionality of the main button
        private void Click_btnShow(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Name: {_person.Name}");
        }

        // a class to define data for a person
        class Person
        {
            public Person()
            {
                    
            }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public int Number { get; set; }
       
        }

    }
}
