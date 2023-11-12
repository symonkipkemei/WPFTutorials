
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WPFViewModels.Model;
using WPFViewModels.MVVM;

namespace WPFViewModels.ViewModel
{
    class MainWindowViewModel: ViewModelBase
    {
        // a list of observable collections from Model 

        public ObservableCollection<Item> Items { get; set; }

        public RelayCommand AddCommand => new RelayCommand(execute =>AddItem());
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(), canExecute => SelectedItem != null);

        public RelayCommand SaveCommand => new RelayCommand(execute => Save(), canExecute => canSave());
        //constructor
        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item 
            {
                Name = "Product1",
                SerialNumber = "0001",
                Quantity = 5,
            
            });

            Items.Add(new Item
            {
                Name = "Product2",
                SerialNumber = "0002",
                Quantity = 5,

            });
        }


        private Item selectedItem;
        public Item SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; OnPropertyChanged(); }
        }

        private void AddItem()
        {
            Items.Add(new Item
            {
                Name = "NEW ITEM",
                SerialNumber="XXXX",
                Quantity = 5,

            });
        }

        private void DeleteItem()
        {
            Items.Remove(selectedItem);
        }

        private void Save()
        {
            //save to db

        }

        private bool CanSave()
        {
            return true;
        }

    }
}

