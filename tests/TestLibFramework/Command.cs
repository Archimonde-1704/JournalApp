using System;
using System.Windows.Input;

namespace TestLibFramework
{
    public abstract class Command : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        private void CommandManager_RequerySuggested(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public abstract bool CanExecute(object parameter);
        public abstract void Execute(object parameter);
    }
}