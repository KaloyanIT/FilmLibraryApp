using System;
using System.Windows.Input;

namespace FilmLibraryApp.Commands
{
    public class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private readonly Action<object> executeAction;
        private readonly Func<object, bool> canExecuteAction;

        public DelegateCommand(Action<object> executeAction, Func<object, bool> canExecuteAction)
        {
            this.executeAction = executeAction;
            this.canExecuteAction = canExecuteAction;
        }


        public bool CanExecute(object parameter)
        {
            return this.canExecuteAction?.Invoke(parameter) ?? true;
        }

        public void Execute(object parameter)
        {
            this.executeAction(parameter);
        }

        public void InvokeCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
