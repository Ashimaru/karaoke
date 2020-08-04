using System;
using SingItBetter.Interfaces.ViewModel;

namespace SingItBetter.UI.ViewModel
{
    public class CommandHandler<TParameter> : ICommandHandler
    {
        private readonly Action<TParameter> _action;

        private readonly Func<bool> _canExecute;

        public CommandHandler(Action<TParameter> action, Func<bool> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _canExecute();
        }

        public void Execute(object parameter)
        {
            if(parameter is TParameter p)
                _action(p);
            else throw new ArgumentException("Invalid parameter type.", nameof(parameter));
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }
    }
}