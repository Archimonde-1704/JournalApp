using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace JournalApp.Infrastructure.Commands.Base
{
    internal class Command : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove +> CommandManager.RequerySuggested -= value;
        }

        private void CommandManager_RequerySuggested(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public bool CanExecute(object parameter) { throw new NotImplementedException(); }
        public bool Execute (object parameter) { throw new NotImplementedException(); }
    }
}
