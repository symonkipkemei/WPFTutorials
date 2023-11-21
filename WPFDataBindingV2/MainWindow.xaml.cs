using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WPFDataBindingV2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window , INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            BoundingText = "Hey kiplelgo uko to sawa";
 
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private string boundingText;

        public string BoundingText
        {
            get { return boundingText; }
            set 
            { 
                boundingText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundingText"));
            }
            
        }
    }
}
