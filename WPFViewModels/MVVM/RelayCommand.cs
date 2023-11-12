using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFViewModels.MVVM
{
    class RelayCommand : ICommand
    {
        // properties
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; } }
    

        // constructor
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        // Methods
        public bool CanExecute(object? parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            execute(parameter);
        }
    }
    
}
 