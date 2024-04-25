using System;
using System.Windows.Input;

namespace MinimalMVVM.ViewModel
{
    public class DelegateStrCommand : ICommand
    {
        private readonly Action<object> _action;

        public DelegateStrCommand(Action<object> action)
        {
            _action = action;
        }

        public void Execute(object parameter)
        {
            _action(parameter);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged { add { } remove { } }
    }
}
